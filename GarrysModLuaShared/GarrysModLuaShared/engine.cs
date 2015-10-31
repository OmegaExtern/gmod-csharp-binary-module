using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The engine library provides functions to access various features in the game's engine, most are related to the demo and save systems.</summary>
    static class engine
    {
        /// <summary>Returns the name of the currently running gamemode.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The active gamemode's name.</returns>
        public static string ActiveGamemode(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(ActiveGamemode));
                lua_pcall(luaState, 0, 1);
                return ToManagedString(luaState);
            }
        }

#if SERVER
        /// <summary>Closes the server and completely exits.<para/>This is only functional when running in server test mode(launch option -systemtest). Server test mode is used internally at Facepunch as part of the build process to make sure that the dedicated servers aren't crashing on startup.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void CloseServer(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(CloseServer));
                lua_pcall(luaState);
            }
        }
#endif

        // TODO: engine.GetAddons (returns a table).

#if CLIENT
        /// <summary>When starting playing a demo, <see cref="GetDemoPlaybackTick"/> will be reset and its old value will be added to this functions return value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns></returns>
        public static double GetDemoPlaybackStartTick(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(GetDemoPlaybackStartTick));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Current tick of currently loaded demo.<para/>If not playing a demo, it will return amount of ticks since last demo playback.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The amount of ticks of currently loaded demo.</returns>
        public static double GetDemoPlaybackTick(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(GetDemoPlaybackTick));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns time scale of demo playback.<para/>If not during demo playback, returns 1.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The time scale of demo playback, value of demo_timescale console variable.</returns>
        public static double GetDemoPlaybackTimeScale(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(GetDemoPlaybackTimeScale));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns total amount of ticks of currently loaded demo.<para/>If not playing a demo, returns 0 or the value of last played demo.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Total amount of ticks of currently loaded demo.</returns>
        public static double GetDemoPlaybackTotalTicks(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(GetDemoPlaybackTotalTicks));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }
#endif

        // TODO: engine.GetGamemodes (returns a table).

        // TODO: engine.GetGames (returns a table).

#if CLIENT
        /// <summary>Returns true if we're currently playing a demo.<para/>You will notice that there's no server-side version of this. That's because there is no server when playing a demo. Demos are both recorded and played back purely clientside.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whether the game is currently playing a demo or not.</returns>
        public static bool IsPlayingDemo(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(IsPlayingDemo));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns true if the game is currently recording a demo file (.dem) using gm_demo console variable.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whether the game is currently recording a demo or not.</returns>
        public static bool IsRecordingDemo(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(IsRecordingDemo));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }
#endif

#if SERVER
        /// <summary>This is a direct binding to the function “engine->LightStyle”. This function allows you to change the default light style of the map - so you can make lighting lighter or darker. You’ll need to call <see cref="render.RedownloadAllLightmaps"/> clientside to refresh the lightmaps to this new color.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="lightstyle">The lightstyle to edit. 0 to 63. If you want to edit map lighting, you want to set this to 0.</param>
        /// <param name="pattern">The pattern to change the lightstyle to. "a" is the darkest, "z" is the brightest. You can use stuff like "abcxyz" to make flashing patterns. The normal brightness for a map is "m".</param>
        public static void LightStyle(LuaState luaState, double lightstyle, string pattern)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(LightStyle));
                lua_pushnumber(luaState, lightstyle);
                lua_pushstring(luaState, pattern);
                lua_pcall(luaState, 2);
            }
        }
#endif

#if CLIENT
        /// <summary>Loads a duplication from the local filesystem.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="dupeName">Name of the file. e.g "dupes/8b809dd7a1a9a375e75be01cdc12e61f.dupe".</param>
        /// <returns>Compressed dupeData. Use <see cref="util.JSONToTable"/> to make it into a format useable by the duplicator tool.</returns>
        public static string OpenDupe(LuaState luaState, string dupeName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(OpenDupe));
                lua_pushstring(luaState, dupeName);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }
#endif

        /// <summary>Returns the number of seconds between each gametick.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Number of seconds between each gametick.</returns>
        public static double TickInterval(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(TickInterval));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

#if CLIENT
        // TODO: engine.VideoSettings (returns a table; VideoData structure).

        /// <summary>Saves a duplication as a file.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="dupe">Dupe table, encoded by <see cref="util.TableToJSON"/> and compressed by <see cref="util.Compress"/>.</param>
        /// <param name="jpeg">The dupe icon, created by <see cref="render.Capture"/>.</param>
        public static void WriteDupe(LuaState luaState, string dupe, string jpeg)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(WriteDupe));
                lua_pushstring(luaState, dupe);
                lua_pushstring(luaState, jpeg);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Stores savedata into the game (can be loaded using the LoadGame menu).</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="saveData">Data generated by <see cref="gmsave.SaveMap"/>.</param>
        /// <param name="name">Name the save will have.</param>
        /// <param name="time">When the save was saved during the game (use <see cref="Global.CurTime"/> here)</param>
        /// <param name="map">The map the save is used for.</param>
        public static void WriteSave(LuaState luaState, string saveData, string name, double time, string map)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(engine));
                lua_getfield(luaState, -1, nameof(WriteSave));
                lua_pushstring(luaState, saveData);
                lua_pushstring(luaState, name);
                lua_pushnumber(luaState, time);
                lua_pushstring(luaState, map);
                lua_pcall(luaState, 4);
            }
        }
#endif
    }
}