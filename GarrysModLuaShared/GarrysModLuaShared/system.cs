using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The system library provides functions that allow you to gather information about the system running the game, such as operating system, uptime and battery level.</summary>
    static class system
    {
        /// <summary>Returns the total uptime of the current application.<para/>This will return a similar value to <see cref="Global.SysTime"/>.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Seconds of game uptime as an integer.</returns>
        public static uint AppTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(AppTime));
                lua_pcall(luaState, 0, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the current battery power.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>0-100 if on battery power.<para/>If plugged in, the value will be 255 regardless of charging state.</returns>
        public static byte BatteryPower(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(BatteryPower));
                lua_pcall(luaState, 0, 1);
                return (byte)lua_tointeger(luaState);
            }
        }

#if CLIENT
        /// <summary>Flashes the window. Currently works only on Windows platform.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void FlashWindow(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(FlashWindow));
                lua_pcall(luaState);
            }
        }
#endif

        /// <summary>Returns the country code of this computer, determined by the localisation settings of the OS.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Two-letter country code, using <see cref="http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1</see> standard.</returns>
        public static string GetCountry(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(GetCountry));
                lua_pcall(luaState, 0, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns whether or not the game window has focus.<para/>This does nothing on dedicated servers.<para/>Returns true 100% of the time on OS X and returns nil on Linux platform.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whether or not the game window has focus.</returns>
        public static bool HasFocus(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(HasFocus));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns whether the current OS is Linux.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whether or not the game is running on Linux.</returns>
        public static bool IsLinux(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(IsLinux));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns whether the current OS is OSX.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whether or not the game is running on OSX.</returns>
        public static bool IsOSX(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(IsOSX));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

#if CLIENT
        /// <summary>Returns true if the game is currently running windowed; otherwise false if it is fullscreen.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Is the game running in a window?</returns>
        public static bool IsWindowed(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(IsWindowed));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }
#endif

        /// <summary>Returns whether the current OS is Windows.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whether the system the game runs on is Windows or not.</returns>
        public static bool IsWindows(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(IsWindows));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns the synchronized steam time. This is the number of seconds since the <see cref="http://en.wikipedia.org/wiki/Unix_time">Unix epoch</see>.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Current steam-synchronized Unix time.</returns>
        public static uint SteamTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(SteamTime));
                lua_pcall(luaState, 0, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the total uptime of operating system.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The total uptime of operating system.</returns>
        public static uint UpTime(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(system));
                lua_getfield(luaState, -1, nameof(UpTime));
                lua_pcall(luaState, 0, 1);
                return (uint)lua_tonumber(luaState);
            }
        }
    }
}