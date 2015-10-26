using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>Used to interface with the built in game events system.</summary>
    static class gameevent
    {
        /// <summary>Add a game event listener.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="eventName">The event to listen to, travels through hooks with eventName as event.<para/>List of valid events can be found <see cref="http://wiki.garrysmod.com/page/Game_Events"/>.</param>
        public static void Listen(IntPtr luaState, string eventName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gameevent));
                lua_getfield(luaState, -1, nameof(Listen));
                lua_pushstring(luaState, eventName);
                lua_pcall(luaState);
            }
        }
    }
}