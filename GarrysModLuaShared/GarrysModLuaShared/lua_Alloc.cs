using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr lua_Alloc(IntPtr ud, IntPtr ptr, IntPtr osize, IntPtr nsize);
}