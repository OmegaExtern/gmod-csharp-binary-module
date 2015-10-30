using System;
using System.Runtime.InteropServices;
using GarrysModLuaShared.Classes;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    public class LuaObject
    {
        protected int Index;

        public LuaObject(int index)
        {
            Index = index;
        }

        public bool GetFieldBoolean(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(Index, name);
                bool value = lua_toboolean().IsTrue();
                lua_pop();
                return value;
            }
        }

        public int GetFieldInteger(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(Index, name);
                int value = lua_tointeger();
                lua_pop();
                return value;
            }
        }

        public double GetFieldNumber(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(Index, name);
                double value = lua_tonumber();
                lua_pop();
                return value;
            }
        }

        public string GetFieldString(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(Index, name);
                string value = ToManagedString();
                lua_pop();
                return value;
            }
        }

        public LuaObject GetFieldObject(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(Index, name);
                return new LuaObject(lua_gettop());
            }
        }

        public LuaTable GetFieldTable(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(Index, name);
                return new LuaTable(lua_gettop());
            }
        }

        public void SetField(string name, bool value)
        {
            lock (SyncRoot)
            {
                lua_pushboolean(value);
                lua_setfield(Index, name);
            }
        }

        public void SetField(string name, int value)
        {
            lock (SyncRoot)
            {
                lua_pushinteger(value);
                lua_setfield(Index, name);
            }
        }

        public void SetField(string name, double value)
        {
            lock (SyncRoot)
            {
                lua_pushnumber(value);
                lua_setfield(Index, name);
            }
        }

        public void SetField(string name, [MarshalAs(UnmanagedType.LPStr)] string value)
        {
            lock (SyncRoot)
            {
                lua_pushstring(value);
                lua_setfield(Index, name);
            }
        }

        public void SetField(string name, LuaObject value)
        {
            lock (SyncRoot)
            {
                lua_pushvalue(value.Index);
                lua_setfield(Index, name);
            }
        }

        public void SetField(string name, object value)
        {
            lock (SyncRoot)
            {
                lua_pushobject(value);
                lua_setfield(Index, name);
            }
        }

        public int Invoke(int results, string name, params object[] args)
        {
            lock (SyncRoot)
            {
                int top = lua_gettop();
                lua_getfield(Index, name);
                int length = 0;
                for (int i = 0; i < args.Length; ++i)
                {
                    object arg = args[i];
                    length++;
                    if (arg is bool)
                    {
                        lua_pushboolean((bool)arg);
                        continue;
                    }
                    if (arg is int)
                    {
                        lua_pushinteger((int)arg);
                        continue;
                    }
                    if (arg is double)
                    {
                        lua_pushnumber((double)arg);
                        continue;
                    }
                    string s = arg as string;
                    if (s != null)
                    {
                        lua_pushstring(s);
                        continue;
                    }
                    lua_CFunction f = arg as lua_CFunction;
                    if (f != null)
                    {
                        lua_pushcclosure(f, 0);
                        continue;
                    }
                    LuaObject o = arg as LuaObject;
                    if (o != null)
                    {
                        lua_pushvalue(o.Index);
                        continue;
                    }
                    lua_pushnil();
                }
                lua_call(length, results);
                return lua_gettop() - top;
            }
        }

        public int Call(int results, string name, params object[] args)
        {
            lock (SyncRoot)
            {
                object[] newArgs = new object[args.Length + 1];
                Array.Copy(args, 0, newArgs, 1, args.Length);
                newArgs[0] = this;
                return Invoke(results, name, newArgs);
            }
        }

        public void InvokeVoid(string name, params object[] args) => Invoke(0, name, args);

        public bool InvokeBoolean(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Invoke(1, name, args);
                bool value = lua_toboolean().IsTrue();
                lua_pop();
                return value;
            }
        }

        public int InvokeInteger(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Invoke(1, name, args);
                int value = lua_tointeger();
                lua_pop();
                return value;
            }
        }

        public double InvokeNumber(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Invoke(1, name, args);
                double value = lua_tonumber();
                lua_pop();
                return value;
            }
        }

        public string InvokeString(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Invoke(1, name, args);
                string value = ToManagedString();
                lua_pop();
                return value;
            }
        }

        public LuaObject InvokeObject(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Invoke(1, name, args);
                return new LuaObject(lua_gettop());
            }
        }

        public void CallVoid(string name, params object[] args) => Call(0, name, args);

        public bool CallBoolean(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Call(1, name, args);
                bool value = lua_toboolean().IsTrue();
                lua_pop();
                return value;
            }
        }

        public int CallInteger(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Call(1, name, args);
                int value = lua_tointeger();
                lua_pop();
                return value;
            }
        }

        public double CallNumber(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Call(1, name, args);
                double value = lua_tonumber();
                lua_pop();
                return value;
            }
        }

        public string CallString(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Call(1, name, args);
                string value = ToManagedString();
                lua_pop();
                return value;
            }
        }

        public LuaObject CallObject(string name, params object[] args)
        {
            lock (SyncRoot)
            {
                Call(1, name, args);
                return new LuaObject(lua_gettop());
            }
        }

        public int GetIndex() => Index;

        public void Pop()
        {
            if (Index != lua_gettop())
            {
                return;
            }
            lua_pop();
            Index = default(int);
        }

        public override string ToString()
        {
            LuaTable._G.Invoke(1, "tostring", this); // TODO: Global.tostring function.
            string value = ToManagedString();
            lua_pop();
            return value;
        }
    }
}