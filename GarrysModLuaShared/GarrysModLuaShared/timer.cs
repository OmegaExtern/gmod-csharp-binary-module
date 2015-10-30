using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The timer library is a very useful set of functions which allow you to run a function periodically or after a given delay.</summary>
    static class timer
    {
        /// <summary>Adjusts the timer if the timer with the given identifier exists.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer to adjust.</param>
        /// <param name="delay">The delay interval in seconds.</param>
        /// <param name="repetitions">Repetitions. Use 0 for infinite.</param>
        /// <param name="function">The new function.</param>
        /// <returns>True if succeeded; otherwise false.</returns>
        public static bool Adjust(IntPtr luaState, object identifier, double delay, uint repetitions, lua_CFunction function)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Adjust));
                lua_pushobject(luaState, identifier);
                lua_pushnumber(luaState, delay);
                lua_pushnumber(luaState, repetitions);
                lua_pushcclosure(luaState, function, 0);
                lua_pcall(luaState, 4, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Creates a new timer.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer to adjust.</param>
        /// <param name="delay">The delay interval in seconds.</param>
        /// <param name="repetitions">The number of times to repeat the timer (use 0 for infinite repetitions).</param>
        /// <param name="function">Function to call when timer has finished the countdown.</param>
        public static void Create(IntPtr luaState, object identifier, double delay, uint repetitions, lua_CFunction function)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Create));
                lua_pushobject(luaState, identifier);
                lua_pushnumber(luaState, delay);
                lua_pushnumber(luaState, repetitions);
                lua_pushcclosure(luaState, function, 0);
                lua_pcall(luaState, 4);
            }
        }

        /// <summary>Returns whenever the given timer exists or not.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>True if the timer exists; otherwise false.</returns>
        public static bool Exists(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Exists));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Pauses the given timer.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>False if the timer doesn't exist or is already paused; otherwise true.</returns>
        public static bool Pause(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Pause));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Stops and removes the timer.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer to remove.</param>
        public static void Remove(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Remove));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Returns amount of repetitions/executions left before the timer destroys itself.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>The amount of executions left.</returns>
        public static uint RepsLeft(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(RepsLeft));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        /// <summary>Runs the given function after a specified delay.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="delay">How long until the function should be ran (in seconds).</param>
        /// <param name="function">The function to run after the specified delay.</param>
        public static void Simple(IntPtr luaState, double delay, lua_CFunction function)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Simple));
                lua_pushnumber(luaState, delay);
                lua_pushcclosure(luaState, function, 0);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Restarts the given timer.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>True if the timer exists; otherwise false.</returns>
        public static bool Start(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Start));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Stops the given timer.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>False if the timer doesn't exist or is already stopped; otherwise true.</returns>
        public static bool Stop(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Stop));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns amount of time left before the timer executes its function.<para/>If the timer is paused, the amount will be negative.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>The amount of time left.</returns>
        public static double TimeLeft(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(TimeLeft));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Runs either <see cref="Pause"/> or <see cref="UnPause"/> based on the timer's current status.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>Status of the timer.</returns>
        public static bool Toggle(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(Toggle));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Unpauses the timer.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="identifier">Identifier of the timer.</param>
        /// <returns>False if the timer doesn't exist or is already running; otherwise true.</returns>
        public static bool UnPause(IntPtr luaState, object identifier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(timer));
                lua_getfield(luaState, -1, nameof(UnPause));
                lua_pushobject(luaState, identifier);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }
    }
}