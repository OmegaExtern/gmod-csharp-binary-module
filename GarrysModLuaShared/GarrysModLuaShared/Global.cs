using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    static class Global
    {
        static readonly object SyncRoot = new object();

        public static void print(IntPtr luaState, params object[] args)
        {
            lock (SyncRoot)
            {
                lua_getfield(luaState, (int)TableIndex.SpecialGlob, nameof(print));
                foreach (object o in args)
                {
                    lua_pushstring(luaState, o.ToString());
                }
                lua_pcall(luaState, args.Length, 0, 0);
            }
        }

        public static void require(IntPtr luaState, string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(luaState, (int)TableIndex.SpecialGlob, nameof(require));
                lua_pushstring(luaState, name);
                lua_pcall(luaState, 1, 0, 0);
            }
        }
    }
}