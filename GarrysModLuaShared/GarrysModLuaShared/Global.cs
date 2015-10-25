using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    static class Global
    {
        public static lua_CFunction CompileFile(IntPtr luaState, string path)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(CompileFile));
                lua_pushstring(luaState, path);
                lua_pcall(luaState, 1, 1);
                return lua_tocfunction(luaState);
            }
        }

        public static lua_CFunction CompileString(IntPtr luaState, string code, string identifier, bool handleError = true)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(CompileString));
                lua_pushstring(luaState, code);
                lua_pushstring(luaState, identifier);
                lua_pushboolean(luaState, handleError ? 1 : 0);
                lua_pcall(luaState, 3, 1);
                return lua_tocfunction(luaState);
            }
        }

        public static double CurTime(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(CurTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static double FrameTime(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(FrameTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static void include(IntPtr luaState, string fileName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(include));
                lua_pushstring(luaState, fileName);
                lua_pcall(luaState, 1);
            }
        }

        public static bool isangle(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isangle));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isbool(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isbool));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool IsColor(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(IsColor));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isentity(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isentity));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isfunction(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isfunction));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isnumber(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isnumber));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool ispanel(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ispanel));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isstring(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isstring));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool istable(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(istable));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool IsValid(IntPtr luaState, object toBeValidated)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(IsValid));
                Push(luaState, toBeValidated);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isvector(IntPtr luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isvector));
                Push(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static double Lerp(IntPtr luaState, double t, double from, double to)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(Lerp));
                lua_pushnumber(luaState, t);
                lua_pushnumber(luaState, from);
                lua_pushnumber(luaState, to);
                lua_pcall(luaState, 3, 1);
                return lua_tonumber(luaState);
            }
        }

        public static void Msg(IntPtr luaState, params object[] args)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(Msg));
                foreach (object o in args)
                {
                    Push(luaState, o);
                }
                lua_pcall(luaState, args.Length);
            }
        }

        public static void MsgN(IntPtr luaState, params object[] args)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(MsgN));
                foreach (object o in args)
                {
                    Push(luaState, o);
                }
                Push(luaState, "\n");
                lua_pcall(luaState, 1 + args.Length);
            }
        }

        public static void print(IntPtr luaState, params object[] args)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(print));
                foreach (object o in args)
                {
                    lua_pushstring(luaState, o.ToString());
                }
                lua_pcall(luaState, args.Length);
            }
        }

        public static bool ProtectedCall(IntPtr luaState, lua_CFunction function)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ProtectedCall));
                lua_pushcclosure(luaState, function, 0);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static double RealFrameTime(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RealFrameTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static double RealTime(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RealTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static void require(IntPtr luaState, string name)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(require));
                lua_pushstring(luaState, name);
                lua_pcall(luaState, 1);
            }
        }

        public static void RunConsoleCommand(IntPtr luaState, string command, params string[] arguments)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RunConsoleCommand));
                lua_pushstring(luaState, command);
                foreach (string argument in arguments)
                {
                    lua_pushstring(luaState, argument);
                }
                lua_pcall(luaState, 1 + arguments.Length);
            }
        }

        public static void RunString(IntPtr luaState, string code)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RunString));
                lua_pushstring(luaState, code);
                lua_pcall(luaState, 1);
            }
        }

        public static void RunStringEx(IntPtr luaState, string code, string identifier = "RunString")
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RunStringEx));
                lua_pushstring(luaState, code);
                lua_pushstring(luaState, identifier);
                lua_pcall(luaState, 2);
            }
        }

#if CLIENT
        public static uint ScrH(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ScrH));
                lua_pcall(luaState, 0, 1, 0);
                return (uint)lua_tointeger(luaState, -1);
            }
        }

        public static uint ScrW(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ScrW));
                lua_pcall(luaState, 0, 1, 0);
                return (uint)lua_tointeger(luaState, -1);
            }
        }
#endif

        public static double SysTime(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(SysTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }
    }
}