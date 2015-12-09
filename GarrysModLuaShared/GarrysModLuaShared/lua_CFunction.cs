using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int lua_CFunction(LuaState luaState);
}