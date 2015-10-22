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

        public static void RunConsoleCommand(IntPtr luaState, string command, params string[] arguments)
        {
            lock (SyncRoot)
            {
                lua_getfield(luaState, (int)TableIndex.SpecialGlob, nameof(RunConsoleCommand));
                lua_pushstring(luaState, command);
                foreach (string argument in arguments)
                {
                    lua_pushstring(luaState, argument);
                }
                lua_pcall(luaState, 1 + arguments.Length, 0, 0);
            }
        }

        public static void RunString(IntPtr luaState, string code)
        {
            lock (SyncRoot)
            {
                lua_getfield(luaState, (int)TableIndex.SpecialGlob, nameof(RunString));
                lua_pushstring(luaState, code);
                lua_pcall(luaState, 1, 0, 0);
            }
        }

        public static void RunStringEx(IntPtr luaState, string code, string identifier = "RunString")
        {
            lock (SyncRoot)
            {
                lua_getfield(luaState, (int)TableIndex.SpecialGlob, nameof(RunStringEx));
                lua_pushstring(luaState, code);
                lua_pushstring(luaState, identifier);
                lua_pcall(luaState, 2, 0, 0);
            }
        }
    }
}