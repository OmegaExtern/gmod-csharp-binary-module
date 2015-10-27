using System;
using GarrysModLuaShared.Enums;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The team library gives you access to the team system built into the Source engine, and allows you to create custom teams and get information about them.</summary>
    static class team
    {
        /// <summary>Increases the score of the given team.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="teamIndex">Index of the team.</param>
        /// <param name="increment">Amount to increase the team's score by.</param>
        public static void AddScore(IntPtr luaState, uint teamIndex, uint increment)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(AddScore));
                lua_pushnumber(luaState, teamIndex);
                lua_pushnumber(luaState, increment);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Returns the team index of the team with the least players. Falls back to <see cref="TEAM.TEAM_UNASSIGNED"/>.</summary>
        /// <param name="luaState"></param>
        /// <returns>Team index.</returns>
        public static uint BestAutoJoinTeam(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(BestAutoJoinTeam));
                lua_pcall(luaState, 0, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        // TODO: team.GetAllTeams (returns a table).

        // TODO: team.GetClass (returns a table).

        // TODO: team.GetColor (returns Color structure).

        /// <summary>Returns the name of the team.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">The team index.</param>
        /// <returns>The name of the team.</returns>
        public static string GetName(IntPtr luaState, uint teamIndex)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(GetName));
                lua_pushnumber(luaState, teamIndex);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: team.GetPlayers (returns a table/array of Player objects).

        /// <summary>Returns the score of the team.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">The team index.</param>
        /// <returns>The score of the team.</returns>
        public static int GetScore(IntPtr luaState, uint teamIndex)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(GetScore));
                lua_pushnumber(luaState, teamIndex);
                lua_pcall(luaState, 1, 1);
                return lua_tointeger(luaState);
            }
        }

        // TODO: team.GetSpawnPoint (return a table).

        // TODO: team.GetSpawnPoints (return a table).

        /// <summary>Returns if a team is joinable or not. This is set in <see cref="SetUp"/>.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">The index of the team.</param>
        /// <returns>True if the team is joinable; otherwise false.</returns>
        public static bool Joinable(IntPtr luaState, uint teamIndex)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(Joinable));
                lua_pushnumber(luaState, teamIndex);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns the amount of players in a team.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">The team index.</param>
        /// <returns>The amount of players in a team.</returns>
        public static uint NumPlayers(IntPtr luaState, uint teamIndex)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(NumPlayers));
                lua_pushnumber(luaState, teamIndex);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tointeger(luaState);
            }
        }

        /// <summary>Sets valid classes for use by a team. Classes can be created using <see cref="player_manager.RegisterClass"/>.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">Index of the team.</param>
        /// <param name="classId">A class ID or table of class IDs.</param>
        public static void SetClass(IntPtr luaState, uint teamIndex, object classId) // TODO: Add table overload after implementing tables.
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(SetClass));
                lua_pushnumber(luaState, teamIndex);
                Push(luaState, classId);
                lua_pcall(luaState, 2);
            }
        }

        // TODO: team.SetColor (takes Color structure as argument).

        /// <summary>Sets the score of the given team.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">Index of the team.</param>
        /// <param name="score">The team's new score.</param>
        public static void SetScore(IntPtr luaState, uint teamIndex, int score)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(SetScore));
                lua_pushnumber(luaState, teamIndex);
                lua_pushnumber(luaState, score);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Sets valid spawnpoint classes for use by a team.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">Index of the team.</param>
        /// <param name="classes">A spawnpoint classname or table of spawnpoint classnames.</param>
        public static void SetSpawnPoint(IntPtr luaState, uint teamIndex, object classes) // TODO: Add table overload after implementing tables.
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(SetSpawnPoint));
                lua_pushnumber(luaState, teamIndex);
                Push(luaState, classes);
                lua_pcall(luaState, 2);
            }
        }

        // TODO: team.SetUp (takes Color structure as argument).

        /// <summary>Returns the sum of deaths of all players of the team.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">The team index.</param>
        /// <returns>The sum of deaths of all players of the team.</returns>
        public static uint TotalDeaths(IntPtr luaState, uint teamIndex)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(TotalDeaths));
                lua_pushnumber(luaState, teamIndex);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tointeger(luaState);
            }
        }

        /// <summary>Returns the sum of frags of all players of the team.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">The team index.</param>
        /// <returns>The sum of frags of all players of the team.</returns>
        public static uint TotalFrags(IntPtr luaState, uint teamIndex)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(TotalFrags));
                lua_pushnumber(luaState, teamIndex);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tointeger(luaState);
            }
        }

        /// <summary>Returns true if the given team index is valid.</summary>
        /// <param name="luaState"></param>
        /// <param name="teamIndex">Index of the team.</param>
        /// <returns>True if the given team index is valid; otherwise false.</returns>
        public static bool Valid(IntPtr luaState, uint teamIndex)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(team));
                lua_getfield(luaState, -1, nameof(Valid));
                lua_pushnumber(luaState, teamIndex);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }
    }
}