using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>
    ///     The os library is a standard Lua library originally intended to allow Lua access to various features of the
    ///     Operating System it's running on, however many of the features and functions have been removed in Garry's Mod due
    ///     to security issues. It's only used in Garry's Mod for date & time operations.
    /// </summary>
    static class os
    {
        /// <summary>Returns the approximate CPU time the application run.
        ///     <para />
        ///     This can be very useful for optimizing as you can use it to find out how long it took your function to run.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The approximate CPU time the application run.</returns>
        public static double clock(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(os));
                lua_getfield(luaState, -1, nameof(clock));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the date/time as a formatted string or in a table.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="format">
        ///     The format string.
        ///     <para />
        ///     If this is equal to '*t' then this function will return a table, otherwise it will return a string.
        ///     <para />
        ///     If this starts with an '!', the returned data will use the UTC timezone rather than the local timezone.
        ///     <para />
        ///     See http://www.mkssoftware.com/docs/man3/strftime.3.asp for available format flags.
        ///     <para />
        ///     Not all flags are available on all operating systems and the result of using an invalid flag is undefined.This
        ///     currently crashes the game on Windows.Most or all flags are available on OS X and Linux but considerably fewer are
        ///     available on Windows.See http://msdn.microsoft.com/en-us/library/fe06s4ak.aspx for a list of available flags on
        ///     Windows.
        /// </param>
        /// <param name="time">Time to use for the format.</param>
        /// <returns>Formatted date. Note: This can be a table if the first argument equals to "*t"!</returns>
        public static string date(LuaState luaState, string format, double time)
        {
            lock (SyncRoot)
            {
                if (format == "*t")
                {
                    //throw new NotSupportedException("TODO: Tables.");
                    return default(string);
                }
                lua_getglobal(luaState, nameof(os));
                lua_getfield(luaState, -1, nameof(date));
                lua_pushstring(luaState, format);
                lua_pushnumber(luaState, time);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Subtracts the second of the first value and rounds the result.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="timeA">The first value.</param>
        /// <param name="timeB">The value to subtract.</param>
        /// <returns>Difference.</returns>
        public static double difftime(LuaState luaState, double timeA, double timeB)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(os));
                lua_getfield(luaState, -1, nameof(difftime));
                lua_pushnumber(luaState, timeA);
                lua_pushnumber(luaState, timeB);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>
        ///     Returns the system time in seconds past the unix epoch. If a table is supplied, the function attempts to build
        ///     a system time with the specified table members.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Seconds passed since Unix epoch.</returns>
        public static double time(LuaState luaState) // TODO: After implementing tables (this takes a DateData structure table).
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(os));
                lua_getfield(luaState, -1, nameof(time));
                lua_pushnil(luaState); // Pushing nil (until tables gets implemented).
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }
    }
}