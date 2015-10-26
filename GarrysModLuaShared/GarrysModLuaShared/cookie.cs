using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>Used to store permanent variables/settings on clients that will persist between servers. They are stored in the cl.db SQLite database located in the root Garry's Mod folder.</summary>
    static class cookie
    {
        /// <summary>Deletes a cookie on the client.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="name">The name of the cookie that you want to delete.</param>
        public static void Delete(IntPtr luaState, string name)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(cookie));
                lua_getfield(luaState, -1, nameof(Delete));
                lua_pushstring(luaState, name);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Gets the value of a cookie on the client as a number.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="name">The name of the cookie that you want to get.</param>
        /// <param name="default">Value to return if the cookie does not exist.</param>
        /// <returns>The cookie value.</returns>
        public static double GetNumber(IntPtr luaState, string name, object @default = null)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(cookie));
                lua_getfield(luaState, -1, nameof(GetNumber));
                lua_pushstring(luaState, name);
                Push(luaState, @default);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Gets the value of a cookie on the client as a string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="name">The name of the cookie that you want to get.</param>
        /// <param name="default">Value to return if the cookie does not exist.</param>
        /// <returns>The cookie value.</returns>
        public static string GetString(IntPtr luaState, string name, object @default = null)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(cookie));
                lua_getfield(luaState, -1, nameof(GetString));
                lua_pushstring(luaState, name);
                Push(luaState, @default);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Sets the value of a cookie on the client.<para/>These are stored in the cl.db file.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="name">The name of the cookie that you want to set.</param>
        /// <param name="value">Value to store in the cookie.</param>
        public static void Set(IntPtr luaState, string name, string value)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(cookie));
                lua_getfield(luaState, -1, nameof(Set));
                lua_pushstring(luaState, name);
                lua_pushstring(luaState, value);
                lua_pcall(luaState, 2);
            }
        }
    }
}