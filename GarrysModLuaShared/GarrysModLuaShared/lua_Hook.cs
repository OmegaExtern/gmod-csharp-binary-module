using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void lua_Hook(LuaState luaState, lua_Debug ar);
}