using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr lua_Reader(IntPtr L, IntPtr data, IntPtr size);
}