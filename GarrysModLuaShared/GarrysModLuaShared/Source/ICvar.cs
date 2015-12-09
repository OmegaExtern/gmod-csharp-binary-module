#if SOURCE_SDK
using System.Runtime.InteropServices;

namespace GarrysModLuaShared.Source
{
    static class ICvar
    {
        /// <summary></summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetValue@ICvar@SourceExports@@CAHPBD0@Z", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetValue(string name, string value);

        /// <summary></summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetValue@ICvar@SourceExports@@CAHPBDH@Z", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetValue(string name, int value);

        /// <summary></summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetValue@ICvar@SourceExports@@CAHPBDM@Z", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetValue(string name, float value);

        /// <summary></summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetValue@ICvar@SourceExports@@CAHPBD_N@Z", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetValue(string name, bool value);
    }
}
#endif