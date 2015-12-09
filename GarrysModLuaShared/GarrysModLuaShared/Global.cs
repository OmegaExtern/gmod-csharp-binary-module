using GarrysModLuaShared.Classes;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>Class that contains global functions.</summary>
    static class Global
    {
        public static Angle Angle(double pitch = default(double), double yaw = default(double), double roll = default(double)) => new Angle(pitch, yaw, roll);

        public static LuaTable Color(byte red = default(byte), byte green = default(byte), byte blue = default(byte), byte alpha = byte.MaxValue) => new LuaTable(LuaTable._G.InvokeObject(nameof(Color), red, green, blue, alpha).GetIndex());

        public static lua_CFunction CompileFile(LuaState luaState, string path)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(CompileFile));
                lua_pushstring(luaState, path);
                lua_pcall(luaState, 1, 1);
                return lua_tocfunction(luaState);
            }
        }

        public static lua_CFunction CompileString(LuaState luaState, string code, string identifier, bool handleError = true)
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

        public static double CurTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(CurTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static Entity Entity(uint entityId) => new Entity(entityId);

        public static double FrameTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(FrameTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static ConVar GetConVar(string name) => new ConVar(name);

        public static void include(LuaState luaState, string fileName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(include));
                lua_pushstring(luaState, fileName);
                lua_pcall(luaState, 1);
            }
        }

        public static bool isangle(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isangle));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isbool(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isbool));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool IsColor(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(IsColor));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isentity(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isentity));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isfunction(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isfunction));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isnumber(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isnumber));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool ispanel(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ispanel));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isstring(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isstring));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool istable(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(istable));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool IsValid(LuaState luaState, object toBeValidated)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(IsValid));
                lua_pushobject(luaState, toBeValidated);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static bool isvector(LuaState luaState, object variable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(isvector));
                lua_pushobject(luaState, variable);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static double Lerp(LuaState luaState, double t, double from, double to)
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

        public static Player LocalPlayer() => new Player(LuaTable._G.InvokeObject(nameof(LocalPlayer)).GetIndex());

        public static VMatrix Matrix(LuaTable data) => new VMatrix(data);

        public static void Msg(LuaState luaState, params object[] args)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(Msg));
                int length = 0;
                for (int i = 0; i < args.Length; ++i)
                {
                    lua_pushobject(luaState, args[i]);
                    length++;
                }
                lua_pcall(luaState, length);
            }
        }

        public static void MsgN(LuaState luaState, params object[] args)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(MsgN));
                int length = 0;
                for (int i = 0; i < args.Length; ++i)
                {
                    lua_pushobject(luaState, args[i]);
                    length++;
                }
                lua_pushstring(luaState, "\n");
                lua_pcall(luaState, 1 + length);
            }
        }

        public static Player Player(uint userId) => new Player(userId);

        public static void print(LuaState luaState, params object[] args)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(print));
                int length = 0;
                for (int i = 0; i < args.Length; ++i)
                {
                    lua_pushstring(luaState, args[i].ToString());
                    length++;
                }
                lua_pcall(luaState, length);
            }
        }

        public static void print(params object[] args) => print(LuaState(), args);

        public static void PrintTable(LuaState luaState, LuaTable tableToPrint, double indent = default(double), LuaTable done = null)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(PrintTable));
                lua_pushobject(luaState, tableToPrint);
                lua_pushnumber(luaState, indent);
                lua_pushobject(luaState, done);
                lua_pcall(luaState, 3);
            }
        }

        public static bool ProtectedCall(LuaState luaState, lua_CFunction function)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ProtectedCall));
                lua_pushcclosure(luaState, function, 0);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        public static double RealFrameTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RealFrameTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static double RealTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RealTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static void require(LuaState luaState, string name)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(require));
                lua_pushstring(luaState, name);
                lua_pcall(luaState, 1);
            }
        }

        public static void RunConsoleCommand(LuaState luaState, string command, params string[] arguments)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RunConsoleCommand));
                lua_pushstring(luaState, command);
                int length = 0;
                for (int i = 0; i < arguments.Length; ++i)
                {
                    lua_pushstring(luaState, arguments[i]);
                    length++;
                }
                lua_pcall(luaState, 1 + length);
            }
        }

        public static void RunString(LuaState luaState, string code)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RunString));
                lua_pushstring(luaState, code);
                lua_pcall(luaState, 1);
            }
        }

        public static void RunStringEx(LuaState luaState, string code, string identifier = "RunString")
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(RunStringEx));
                lua_pushstring(luaState, code);
                lua_pushstring(luaState, identifier);
                lua_pcall(luaState, 2);
            }
        }

        public static double SysTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(SysTime));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static Vector Vector(double x = default(double), double y = default(double), double z = default(double)) => new Vector(x, y, z);

#if CLIENT
        public static uint ScrH(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ScrH));
                lua_pcall(luaState, 0, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        public static uint ScrW(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(ScrW));
                lua_pcall(luaState, 0, 1);
                return (uint)lua_tonumber(luaState);
            }
        }
#endif
    }
}