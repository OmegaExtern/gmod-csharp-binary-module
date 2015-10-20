using System;
using static GarrysModLuaShared.Global;

namespace GarrysModLuaShared
{
    static class MyCSharpLibrary
    {
        public static int MyCSharpFunction(IntPtr luaState)
        {
            print(luaState, "Hello from C# binary module!");
            return 0;
        }
    }
}