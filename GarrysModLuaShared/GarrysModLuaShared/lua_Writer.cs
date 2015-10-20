using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int lua_Writer(IntPtr L, IntPtr buffer, IntPtr size, IntPtr data);
}