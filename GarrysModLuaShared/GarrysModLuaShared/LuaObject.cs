using System;
using System.Runtime.InteropServices;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    public class LuaObject
    {
        int _index;

        public LuaObject(int index) { _index = index; }

        public int Call(int results, string name, params object[] args)
        {
            lock (SyncRoot)
            {
                try
                {
                    object[] newArgs = new object[args.Length + 1];
                    Array.Copy(args, 0, newArgs, 1, args.Length);
                    newArgs[0] = this;
                    return Invoke(results, name, newArgs);
                }
                catch (OverflowException)
                {
                    return default(int);
                }
                catch (ArgumentNullException)
                {
                    return default(int);
                }
                catch (RankException)
                {
                    return default(int);
                }
                catch (ArrayTypeMismatchException)
                {
                    return default(int);
                }
                catch (ArgumentOutOfRangeException)
                {
                    return default(int);
                }
                catch (InvalidCastException)
                {
                    return default(int);
                }
                catch (ArgumentException)
                {
                    return default(int);
                }
            }
        }

        public void CallVoid(string name, params object[] args) => Call(0, name, args);

        public bool CallBoolean(string name, params object[] args)
        {
            Call(1, name, args);
            bool value = lua_toboolean().IsTrue();
            lua_pop();
            return value;
        }

        public int CallInteger(string name, params object[] args)
        {
            Call(1, name, args);
            int value = lua_tointeger();
            lua_pop();
            return value;
        }

        public double CallNumber(string name, params object[] args)
        {
            Call(1, name, args);
            double value = lua_tonumber();
            lua_pop();
            return value;
        }

        public string CallString(string name, params object[] args)
        {
            Call(1, name, args);
            string value = ToManagedString();
            lua_pop();
            return value;
        }

        public LuaObject CallObject(string name, params object[] args)
        {
            Call(1, name, args);
            return new LuaObject(lua_gettop());
        }

        public LuaTable CallTable(string name, params object[] args)
        {
            Call(1, name, args);
            return new LuaTable(lua_gettop());
        }

        public bool GetFieldBoolean(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(_index, name);
                bool value = lua_toboolean().IsTrue();
                lua_pop();
                return value;
            }
        }

        public int GetFieldInteger(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(_index, name);
                int value = lua_tointeger();
                lua_pop();
                return value;
            }
        }

        public double GetFieldNumber(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(_index, name);
                double value = lua_tonumber();
                lua_pop();
                return value;
            }
        }

        public string GetFieldString(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(_index, name);
                string value = ToManagedString();
                lua_pop();
                return value;
            }
        }

        public LuaObject GetFieldObject(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(_index, name);
                return new LuaObject(lua_gettop());
            }
        }

        public LuaTable GetFieldTable(string name)
        {
            lock (SyncRoot)
            {
                lua_getfield(_index, name);
                return new LuaTable(lua_gettop());
            }
        }

        public int GetIndex() => _index;

        public int Invoke(int results, string name, params object[] args)
        {
            lock (SyncRoot)
            {
                int top = lua_gettop();
                lua_getfield(_index, name);
                int length = 0;
                for (int i = 0; i < args.Length; ++i)
                {
                    lua_pushobject(args[i]);
                    length++;
                }
                lua_call(length, results);
                return lua_gettop() - top;
            }
        }

        public void InvokeVoid(string name, params object[] args) => Invoke(0, name, args);

        public bool InvokeBoolean(string name, params object[] args)
        {
            Invoke(1, name, args);
            bool value = lua_toboolean().IsTrue();
            lua_pop();
            return value;
        }

        public int InvokeInteger(string name, params object[] args)
        {
            Invoke(1, name, args);
            int value = lua_tointeger();
            lua_pop();
            return value;
        }

        public double InvokeNumber(string name, params object[] args)
        {
            Invoke(1, name, args);
            double value = lua_tonumber();
            lua_pop();
            return value;
        }

        public string InvokeString(string name, params object[] args)
        {
            Invoke(1, name, args);
            string value = ToManagedString();
            lua_pop();
            return value;
        }

        public LuaObject InvokeObject(string name, params object[] args)
        {
            Invoke(1, name, args);
            return new LuaObject(lua_gettop());
        }

        public LuaTable InvokeTable(string name, params object[] args)
        {
            Invoke(1, name, args);
            return new LuaTable(lua_gettop());
        }

        public void Pop()
        {
            if (_index != lua_gettop())
            {
                return;
            }
            lua_pop();
            _index = default(int);
        }

        public void SetField(string name, bool value)
        {
            lock (SyncRoot)
            {
                lua_pushboolean(value);
                lua_setfield(_index, name);
            }
        }

        public void SetField(string name, int value)
        {
            lock (SyncRoot)
            {
                lua_pushinteger(value);
                lua_setfield(_index, name);
            }
        }

        public void SetField(string name, double value)
        {
            lock (SyncRoot)
            {
                lua_pushnumber(value);
                lua_setfield(_index, name);
            }
        }

        public void SetField(string name, [MarshalAs(UnmanagedType.LPStr)] string value)
        {
            lock (SyncRoot)
            {
                lua_pushstring(value);
                lua_setfield(_index, name);
            }
        }

        public void SetField(string name, LuaObject value)
        {
            lock (SyncRoot)
            {
                lua_pushvalue(value._index);
                lua_setfield(_index, name);
            }
        }

        public void SetField(string name, object value)
        {
            lock (SyncRoot)
            {
                lua_pushobject(value);
                lua_setfield(_index, name);
            }
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