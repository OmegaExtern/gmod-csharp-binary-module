using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr lua_Reader(LuaState luaState, IntPtr data, IntPtr size);
}