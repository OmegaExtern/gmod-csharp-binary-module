using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int lua_Writer(LuaState luaState, IntPtr buffer, IntPtr size, IntPtr data);
}