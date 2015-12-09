#if CLIENT
using GarrysModLuaShared.Enums;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>Used to display notifications on the screen (mid-right).</summary>
    static class notification
    {
        /// <summary>Adds a standard notification to your screen.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="text">The string to display.</param>
        /// <param name="notifyType">Determines the method for displaying the notification.</param>
        /// <param name="length">The number of seconds to display the notification for.</param>
        public static void AddLegacy(LuaState luaState, string text, NOTIFY notifyType, double length)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(notification));
                lua_getfield(luaState, -1, nameof(AddLegacy));
                lua_pushstring(luaState, text);
                lua_pushnumber(luaState, (int)notifyType);
                lua_pushnumber(luaState, length);
                lua_pcall(luaState, 3);
            }
        }

        /// <summary>Adds a notification with an animated progress bar.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="uniqueId">Can be any type. It's used as an index.</param>
        /// <param name="text">The text to show.</param>
        public static void AddProgress(LuaState luaState, object uniqueId, string text)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(notification));
                lua_getfield(luaState, -1, nameof(AddProgress));
                lua_pushobject(luaState, uniqueId);
                lua_pushstring(luaState, text);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Removes the notification after 0.8 seconds.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="uniqueId">The unique ID of the notification.</param>
        public static void Kill(LuaState luaState, object uniqueId)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(notification));
                lua_getfield(luaState, -1, nameof(Kill));
                lua_pushobject(luaState, uniqueId);
                lua_pcall(luaState, 1);
            }
        }
    }
}

#endif