#if SOURCE_SDK
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GarrysModLuaShared
{
    static class SourceEngine
    {
        const bool Suspend = true;
        public static readonly Process CurrentProcess = Process.GetCurrentProcess();
        static readonly string DllName = Path.Combine(Path.GetDirectoryName(CurrentProcess.MainModule.FileName) ?? "", ExternDll.SourceExports);

        static SourceEngine()
        {
            if ((DllName.Length < 49) || !File.Exists(DllName))
            {
                Global.print($"Source Exports: \"{DllName}\" file was not found!");
                return;
            }
            if (CurrentProcess.Modules.Cast<ProcessModule>().Any(module => string.Equals(module.FileName, DllName, StringComparison.CurrentCultureIgnoreCase)))
            {
                Global.print($"Source Exports: Module is already injected into {CurrentProcess.ProcessName} process.");
                return;
            }
            int length = DllName.Length;
            IntPtr allocationPointer = IntPtr.Zero;
            IntPtr remoteThread = IntPtr.Zero;
            try
            {
                Process.EnterDebugMode();
                Global.print("Source Exports: Entering debug mode.");
                if (Suspend && !IsSuspended(CurrentProcess) && !SuspendProcess(CurrentProcess))
                {
                    Global.print($"Source Exports: Failed to suspend {CurrentProcess.ProcessName} process!");
                    return;
                }
                IntPtr kernel32 = NativeMethods.GetModuleHandleA(ExternDll.Kernel32); //NativeMethods.LoadLibraryA(ExternDll.Kernel32);
                if (kernel32 == IntPtr.Zero)
                {
                    Global.print($"Source Exports: Failed to retrieve the base address of '{ExternDll.Kernel32}' library!");
                    return;
                }
                IntPtr loadLibrary = NativeMethods.GetProcAddress(kernel32, nameof(NativeMethods.LoadLibraryA));
                //NativeMethods.FreeLibrary(kernel);
                if (loadLibrary == IntPtr.Zero)
                {
                    Global.print($"Source Exports: Failed to retrieve the procedure address for '{nameof(NativeMethods.LoadLibraryA)}' function!");
                    return;
                }

                //allocationPointer = NativeMethods.VirtualAllocEx(CurrentProcess.Handle, IntPtr.Zero, length, AllocationType.Commit, MemoryProtection.ExecuteReadWrite);
                allocationPointer = NativeMethods.VirtualAllocEx(CurrentProcess.Handle, IntPtr.Zero, length, AllocationType.Commit | AllocationType.Reserve, MemoryProtection.ReadWrite);
                if (allocationPointer == IntPtr.Zero)
                {
                    Global.print($"Source Exports: Failed to allocate memory in remote process (module path size = {length * sizeof(char)}, length = {length})!");
                    return;
                }
                int numberOfBytesWritten;
                byte[] buffer = Encoding.ASCII.GetBytes(DllName);
                bool wasWritten = NativeMethods.WriteProcessMemory(CurrentProcess.Handle, allocationPointer, buffer, buffer.Length, out numberOfBytesWritten);
                if (!wasWritten || (numberOfBytesWritten == default(int)) || (numberOfBytesWritten < buffer.Length))
                {
                    Global.print("Source Exports: Failed to write module path to remote memory!");
                    return;
                }
                remoteThread = NativeMethods.CreateRemoteThread(CurrentProcess.Handle, IntPtr.Zero, default(uint), loadLibrary, allocationPointer, default(uint), IntPtr.Zero);
                if (remoteThread == IntPtr.Zero)
                {
                    Global.print("Source Exports: Failed to create a remote thread!");
                    return;
                }
                if (NativeMethods.WaitForSingleObject(remoteThread, 0xFFFFFFFFU) != default(uint))
                {
                    Global.print("Source Exports: Unsuccessful value returned from WaitForSingleObject call!");
                    return;
                }
                uint exitCode;
                if (!NativeMethods.GetExitCodeThread(remoteThread, out exitCode))
                {
                    Global.print("Source Exports: Unsuccessful value returned from GetExitCodeThread call!");
                    return;
                }
                if (exitCode == default(uint))
                {
                    Global.print("Source Exports: Invalid address was returned from a remote thread for loaded module!");
                }
            }
            catch (Exception ex)
            {
                Global.print($"Source Exports: ERROR! {ex.Message}");
            }
            finally
            {
                if (remoteThread != IntPtr.Zero)
                {
                    Global.print(NativeMethods.CloseHandle(remoteThread) ? "Source Exports: Closed remote thread handle." : "Source Exports: Failed to close an open (remote thread) handle (on cleanup)!");
                }
                if (allocationPointer != IntPtr.Zero)
                {
                    //NativeMethods.VirtualFreeEx(CurrentProcess.Handle, allocationPointer, length, AllocationType.Decommit);
                    Global.print(NativeMethods.VirtualFreeEx(CurrentProcess.Handle, allocationPointer, default(int), AllocationType.Release) ? "Source Exports: VirtualFreeEx cleanup." : "Source Exports: VirtualFreeEx returned false (on cleanup)!");
                }
                if (Suspend && IsSuspended(CurrentProcess))
                {
                    Global.print(ResumeProcess(CurrentProcess) ? $"Source Exports: Resumed {CurrentProcess.ProcessName} process." : $"Source Exports: Failed to resume {CurrentProcess.ProcessName} process (on cleanup)!");
                }
                Global.print("Source Exports: Leaving debug mode.");
                Process.LeaveDebugMode();
            }
        }

        static bool IsSuspended(Process process)
        {
            try
            {
                return (process.Threads[0].ThreadState == ThreadState.Wait) && (process.Threads[0].WaitReason == ThreadWaitReason.Suspended);
            }
            catch
            {
                return false;
            }
        }

        static bool SuspendProcess(Process process)
        {
            try
            {
                IntPtr threadHandle = NativeMethods.OpenThread(ThreadAccess.SuspendResume, false, process.Threads[0].Id);
                if (threadHandle == IntPtr.Zero)
                {
                    return false;
                }
                NativeMethods.SuspendThread(threadHandle);
                NativeMethods.CloseHandle(threadHandle);
            }
            catch
            {
                return false;
            }
            return true;
        }

        static bool ResumeProcess(Process process, bool forceResume = false)
        {
            try
            {
                IntPtr threadHandle = NativeMethods.OpenThread(ThreadAccess.SuspendResume, false, process.Threads[0].Id);
                if (threadHandle == IntPtr.Zero)
                {
                    return false;
                }
                if (forceResume)
                {
                    while (NativeMethods.ResumeThread(threadHandle) != default(uint))
                    {
                    }
                }
                else
                {
                    NativeMethods.ResumeThread(threadHandle);
                }
                NativeMethods.CloseHandle(threadHandle);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }

    [Flags]
    enum AllocationType
    {
        Commit = 4096,
        Reserve = 8192,
        Decommit = 16384,
        Release = 32768,
        Reset = 524288,
        Physical = 4194304,
        TopDown = 1048576,
        WriteWatch = 2097152,
        LargePages = 536870912
    }

    [Flags]
    enum MemoryProtection
    {
        NoAccess = 1,
        ReadOnly = 2,
        ReadWrite = 4,
        WriteCopy = 8,
        Execute = 16,
        ExecuteRead = 32,
        ExecuteReadWrite = 64,
        ExecuteWriteCopy = 128,
        GuardModifier = 256,
        NoCacheModifier = 512,
        WriteCombineModifier = 1024
    }

    [Flags]
    enum ThreadAccess
    {
        Terminate = 1,
        SuspendResume = 2,
        GetContext = 8,
        SetContext = 16,
        SetInformation = 32,
        QueryInformation = 64,
        SetThreadToken = 128,
        Impersonate = 256,
        DirectImpersonation = 512
    }

    static class NativeMethods
    {
        [DllImport(ExternDll.Kernel32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport(ExternDll.Kernel32)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport(ExternDll.Kernel32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetExitCodeThread(IntPtr hThread, out uint lpExitCode);

        [DllImport(ExternDll.Kernel32)]
        public static extern IntPtr GetModuleHandleA(string lpModuleName);

        [DllImport(ExternDll.Kernel32)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport(ExternDll.Kernel32)]
        public static extern IntPtr LoadLibraryA(string lpFileName);

        [DllImport(ExternDll.Kernel32)]
        public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, int dwThreadId);

        [DllImport(ExternDll.Kernel32)]
        public static extern uint ResumeThread(IntPtr hThread);

        [DllImport(ExternDll.Kernel32)]
        public static extern uint SuspendThread(IntPtr hThread);

        [DllImport(ExternDll.Kernel32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateThread(IntPtr hThread, uint dwExitCode);

        [DllImport(ExternDll.Kernel32)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

        [DllImport(ExternDll.Kernel32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocationType flFreeType);

        [DllImport(ExternDll.Kernel32)]
        public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        [DllImport(ExternDll.Kernel32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);
    }
}
#endif