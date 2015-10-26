#if CLIENT
using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>Used to interface with the built in game events system.</summary>
    static class menu
    {
        /// <summary>Used by "Demo to Video" to record the frame.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void RecordFrame(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(menu));
                lua_getfield(luaState, -1, nameof(RecordFrame));
                lua_pcall(luaState, 1);
            }
        }
    }
}
#endif