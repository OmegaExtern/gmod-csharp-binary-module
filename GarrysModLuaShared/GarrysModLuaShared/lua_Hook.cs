using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void lua_Hook(IntPtr L, lua_Debug ar);
}