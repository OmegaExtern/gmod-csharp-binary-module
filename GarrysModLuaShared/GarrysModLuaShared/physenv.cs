using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The physenv library allows you to control the physics environment created by the engine, and lets you modify constants such as gravity and maximum velocity.</summary>
    static class physenv
    {
        /// <summary>Loads the given surface properties as a string, follows the file format.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="properties">The properties to add.</param>
        public static void AddSurfaceData(LuaState luaState, string properties)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(physenv));
                lua_getfield(luaState, -1, nameof(AddSurfaceData));
                lua_pushstring(luaState, properties);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Returns the air density.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The air density.</returns>
        public static double GetAirDensity(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(physenv));
                lua_getfield(luaState, -1, nameof(GetAirDensity));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        // TODO: physenv.GetGravity (returns Vector structure).

        // TODO: physenv.GetPerformanceSettings (returns PhysEnvPerformanceSettings structure).

        /// <summary>Sets the air density.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="airDensity">The new air density.</param>
        public static void SetAirDensity(LuaState luaState, double airDensity)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(physenv));
                lua_getfield(luaState, -1, nameof(SetAirDensity));
                lua_pushnumber(luaState, airDensity);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: physenv.SetGravity (takes Vector structure as argument).

        // TODO: physenv.SetPerformanceSettings (takes PhysEnvPerformanceSettings structure as argument).
    }
}