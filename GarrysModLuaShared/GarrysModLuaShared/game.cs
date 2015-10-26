using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The game library provides functions to access various features in the game's engine, most of it's functions are related to controlling the map.</summary>
    static class game
    {
        // TODO: game.AddAmmoType (takes a table argument; AmmoData structure).

        /// <summary>Registers a new decal.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="decalName">The name of the decal.</param>
        /// <param name="materialName">The material to be used for the decal. May also be a list of material names, in which case a random material from that list will be chosen every time the decal is placed.</param>
        public static void AddDecal(IntPtr luaState, string decalName, string materialName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(AddDecal));
                lua_pushstring(luaState, decalName);
                lua_pushstring(luaState, materialName);
                lua_pcall(luaState, 2);
            }
        }

#if CLIENT
        /// <summary>Loads a particle file.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="particleFileName">The path of the file to add. Must be (file).pcf.</param>
        public static void AddParticles(IntPtr luaState, string particleFileName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(AddParticles));
                lua_pushstring(luaState, particleFileName);
                lua_pcall(luaState, 1);
            }
        }
#endif

        // TODO: game.BuildAmmoTypes (returns a table).

        // TODO: game.CleanUpMap (takes a table argument).

#if SERVER
        /// <summary>Runs a console command. Make sure to add a newline ("\n") at the end of the command.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="stringCommand">String containing the command and arguments to be ran.</param>
        public static void ConsoleCommand(IntPtr luaState, string stringCommand)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(ConsoleCommand));
                lua_pushstring(luaState, stringCommand);
                lua_pcall(luaState, 1);
            }
        }
#endif

        /// <summary>Returns the ammo type ID for given ammo type name. See <see cref="GetAmmoName"/> for reverse.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="name">Name of the ammo type to look up ID of.</param>
        /// <returns>The ammo type ID of given ammo type name, or -1 if not found.</returns>
        public static double GetAmmoID(IntPtr luaState, string name)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetAmmoID));
                lua_pushstring(luaState, name);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the real maximum amount of ammo of given ammo ID.<para/>Note: Currently all ammo types have overridden maximum value of reserve ammo set to 9999.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="id">Ammo type ID.</param>
        /// <returns>The maximum amount of reserve ammo a player can hold of this ammo type.</returns>
        public static double GetAmmoMax(IntPtr luaState, double id)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetAmmoMax));
                lua_pushnumber(luaState, id);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the ammo name for given ammo type ID. See <see cref="GetAmmoID"/> for reverse.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="id">Ammo ID to retrieve the name of. Starts from 1.</param>
        /// <returns>The name of given ammo type ID or nil if ammo type ID is invalid.</returns>
        public static string GetAmmoName(IntPtr luaState, double id)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetAmmoName));
                lua_pushnumber(luaState, id);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the name of the current map, without a file extension.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The name of the current map, without a file extension.</returns>
        public static string GetMap(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetMap));
                lua_pcall(luaState, 0, 1);
                return ToManagedString(luaState);
            }
        }

#if SERVER
        /// <summary>Returns the next map that would be loaded according to the file that is set by the mapcyclefile convar.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Next map.</returns>
        public static string GetMapNext(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetMapNext));
                lua_pcall(luaState, 0, 1);
                return ToManagedString(luaState);
            }
        }
#endif

        /// <summary>Returns the VBSP version of the current map.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Map version.</returns>
        public static double GetMapVersion(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetMapVersion));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the difficulty level of the game.<para/>TIP: You can use this function in your scripted NPCs or Nextbots to make them harder, however, it is a good idea to lock powerful attacks behind the highest difficulty instead of just increasing the health.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The difficulty level, Easy( 1 ), Normal( 2 ), Hard( 3 ).</returns>
        public static double GetSkillLevel(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetSkillLevel));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the timescale of the game.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Timescale.</returns>
        public static double GetTimeScale(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(GetTimeScale));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        // TODO: game.GetWorld (returns an Entity type).

        /// <summary>Returns whenever the server or the server we are connected to is a dedicated server.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>True if connected to dedicated server; otherwise false.</returns>
        public static bool IsDedicated(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(IsDedicated));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

#if SERVER
        /// <summary>Loads the next map according to the file that is set by the mapcyclefile convar.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void LoadNextMap(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(LoadNextMap));
                lua_pcall(luaState);
            }
        }

        /// <summary>Returns the map load type of the current map.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The load type. Possible values are: "newgame", "loadgame", "transition", "background".</returns>
        public static string MapLoadType(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(MapLoadType));
                lua_pcall(luaState, 0, 1);
                return ToManagedString(luaState);
            }
        }
#endif

        /// <summary>Returns the maximum number of players for this server.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Max players.</returns>
        public static double MaxPlayers(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(MaxPlayers));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Removes all the clientside ragdolls.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void RemoveRagdolls(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(RemoveRagdolls));
                lua_pcall(luaState);
            }
        }

#if SERVER
        /// <summary>Sets the difficulty level of the game, can be retrieved with game.GetSkillLevel.<para/>This will automatically change whenever the "skill" convar is modified serverside.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="level">The difficulty level, Easy( 1 ), Normal( 2 ), Hard( 3 ).</param>
        public static void SetSkillLevel(IntPtr luaState, double level)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(SetSkillLevel));
                lua_pushnumber(luaState, level);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Sets the time scale of the game.<para/>This function is supposed to remove the need of using the host_timescale convar, which is cheat protected.<para/>To slow down or speed up the movement of a specific player, use <see cref="Player.SetLaggedMovementValue"/> instead.<para/>NOTE: Like host_timescale, this method does not affect sounds, if you wish to change that, look into EntityEmitSound hook.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="timeScale">The new timescale, minimum value is 0.001 and maximum is 5.</param>
        public static void SetTimeScale(IntPtr luaState, double timeScale)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(SetTimeScale));
                lua_pushnumber(luaState, timeScale);
                lua_pcall(luaState, 1);
            }
        }
#endif

        /// <summary>Returns whenever the current session is a single player game.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Is single player?</returns>
        public static bool SinglePlayer(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(game));
                lua_getfield(luaState, -1, nameof(SinglePlayer));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        // TODO: game.StartSpot (returns a Vector type).
    }
}