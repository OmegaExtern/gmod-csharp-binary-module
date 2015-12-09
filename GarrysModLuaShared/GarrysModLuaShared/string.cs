using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The string type is a sequence of characters.
    ///     <para />
    ///     The string library is a standard Lua library which provides functions for the manipulation of strings.
    ///     <para />
    ///     In Garry's Mod there are several extra useful functions added to this library.
    /// </summary>
    static class @string
    {
        /// <summary>Returns the given string's characters in their numeric ASCII representation.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to get the chars from.</param>
        /// <param name="startPos">The first character of the string to get the byte of.</param>
        /// <param name="endPos">The last character of the string to get the byte of.</param>
        /// <returns>Numerical bytes.</returns>
        public static byte[] @byte(LuaState luaState, string inputString, uint startPos = 1U, uint endPos = 1U)
        {
            lock (SyncRoot)
            {
                if (startPos > inputString.Length)
                {
                    return null;
                }
                if (startPos < 1U)
                {
                    startPos = 1U;
                }
                if (endPos < startPos)
                {
                    endPos = startPos;
                }
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(@byte));
                lua_pushstring(luaState, inputString);
                lua_pushnumber(luaState, startPos);
                lua_pushnumber(luaState, endPos);
                int length = (int)(1 + (endPos - startPos));
                lua_pcall(luaState, 3, length);
                byte[] numericalBytes = new byte[length];
                for (int i = 0; i < length; ++i)
                {
                    numericalBytes[i] = (byte)lua_tointeger(luaState, -1 - i);
                }
                return numericalBytes;
            }
        }

        /// <summary>Takes the given numerical bytes and converts them to a string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="bytes">The bytes to create the string from.</param>
        /// <returns>String built from given bytes.</returns>
        public static string @char(LuaState luaState, params byte[] bytes)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(@char));
                int length = 0;
                for (int i = 0; i < bytes.Length; ++i)
                {
                    lua_pushinteger(luaState, bytes[i]);
                    length++;
                }
                lua_pcall(luaState, length, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Inserts commas for every third digit.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputNumber">The input number to commafy.</param>
        /// <returns>Pretty string.</returns>
        public static string Comma(LuaState luaState, double inputNumber)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(Comma));
                lua_pushnumber(luaState, inputNumber);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: string.dump (takes function as argument).

        /// <summary>Returns whether or not the second passed string matches the end of the first.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string whose end is to be checked.</param>
        /// <param name="endString">The string to be matched with the end of the first.</param>
        /// <returns>
        ///     True if the <paramref name="inputString" /> ends with <paramref name="endString" />, or when
        ///     <paramref name="endString" /> is empty; otherwise false.
        /// </returns>
        public static bool EndsWith(LuaState luaState, string inputString, string endString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(EndsWith));
                lua_pushstring(luaState, inputString);
                lua_pushstring(luaState, endString);
                lua_pcall(luaState, 2, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        // TODO: string.Explode (returns a table).

        /// <summary>
        ///     Attempts to find the specified substring in a string, uses
        ///     <see cref="http://wiki.garrysmod.com/page/Patterns">patterns</see> by default.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="hayStack">The string to search in.</param>
        /// <param name="needle">The string to find, can contain patterns if enabled.</param>
        /// <param name="startPos">
        ///     The position to start the search from, can be negative start position will be relative to the
        ///     end position.
        /// </param>
        /// <param name="noPatterns">Set to true to disable patterns.</param>
        /// <returns>First result is the starting position of the found text. Second result is the ending position of found text.</returns>
        public static Tuple<int, int> find(LuaState luaState, string hayStack, string needle, int startPos = 1, bool noPatterns = false)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(find));
                lua_pushstring(luaState, hayStack);
                lua_pushstring(luaState, needle);
                lua_pushinteger(luaState, startPos);
                lua_pushboolean(luaState, noPatterns);
                lua_pcall(luaState, 4, 2);
                return new Tuple<int, int>(lua_tointeger(luaState), lua_tointeger(luaState, -2));
            }
        }

        /// <summary>
        ///     Attempts to find the specified substring in a string, uses
        ///     <see cref="http://wiki.garrysmod.com/page/Patterns">patterns</see> by default.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="start">Starting position of the found text.</param>
        /// <param name="end">Ending position of found text.</param>
        /// <param name="hayStack">The string to search in.</param>
        /// <param name="needle">The string to find, can contain patterns if enabled.</param>
        /// <param name="startPos">
        ///     The position to start the search from, can be negative start position will be relative to the
        ///     end position.
        /// </param>
        /// <param name="noPatterns">Set to true to disable patterns.</param>
        public static void find(LuaState luaState, out int start, out int end, string hayStack, string needle, int startPos = 1, bool noPatterns = false)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(find));
                lua_pushstring(luaState, hayStack);
                lua_pushstring(luaState, needle);
                lua_pushinteger(luaState, startPos);
                lua_pushboolean(luaState, noPatterns);
                lua_pcall(luaState, 4, 2);
                start = lua_tointeger(luaState);
                end = lua_tointeger(luaState, -2);
            }
        }

        /// <summary>Formats the specified values into the string given.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to be formatted.
        ///     <para />
        ///     Follows <see cref="http://www.cplusplus.com/reference/cstdio/printf/">this format</see>.
        /// </param>
        /// <param name="formatParameters">Values to be formatted into the string.</param>
        /// <returns>Formatted string.</returns>
        public static string format(LuaState luaState, string inputString, params object[] formatParameters)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(format));
                lua_pushstring(luaState, inputString);
                int length = 0;
                for (int i = 0; i < formatParameters.Length; ++i)
                {
                    lua_pushobject(luaState, formatParameters[i]);
                    length++;
                }
                lua_pcall(luaState, 1 + length, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the time as a formatted string or as a table if no format is given.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="float">The time in seconds to format.</param>
        /// <param name="format">An optional formatting to use. If no format it specified, a table will be returned instead.</param>
        /// <returns>Returns the time as a formatted string only if a <paramref name="format" /> was specified.
        ///     <para />
        ///     Returns a table only if no <paramref name="format" /> was specified. The table will contain these fields:
        ///     <para />
        ///     number ms - milliseconds
        ///     <para />
        ///     number s - seconds
        ///     <para />
        ///     number m - minutes
        ///     <para />
        ///     number h - hours
        /// </returns>
        public static string FormattedTime(LuaState luaState, double @float, string format)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(FormattedTime));
                lua_pushnumber(luaState, @float);
                if (format != null)
                {
                    lua_pushstring(luaState, format);
                }
                else
                {
                    lua_pushnil(luaState);
                }
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState); // Returns a table if format string is null. TODO: After implementing tables.
            }
        }

        // TODO: string.FromColor (takes a Color structure as argument).

        /// <summary>Returns extension of the file.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="fileName">String e.g. file-path to get the file extensions from.</param>
        /// <returns>File extension.</returns>
        public static string GetExtensionFromFilename(LuaState luaState, string fileName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(GetExtensionFromFilename));
                lua_pushstring(luaState, fileName);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns file name and extension.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="fileName">The string e.g. file-path to get the file-name from.</param>
        /// <returns>The file name.</returns>
        public static string GetFileFromFilename(LuaState luaState, string fileName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(GetFileFromFilename));
                lua_pushstring(luaState, fileName);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the path only from a file's path.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="fileName">String to get path from.</param>
        /// <returns>The path (with trailing slash).</returns>
        public static string GetPathFromFilename(LuaState luaState, string fileName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(GetPathFromFilename));
                lua_pushstring(luaState, fileName);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: string.gmatch (returns a function).

        /// <summary>
        ///     This functions main purpose is to replace certain character sequences in a string using
        ///     <see cref="http://wiki.garrysmod.com/page/Patterns">patterns</see>.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="input">String which should be modified.</param>
        /// <param name="pattern">The pattern that defines what should be matched and eventually be replaced.</param>
        /// <param name="replacement">
        ///     In case of a string the matches sequence will be replaced with it.
        ///     <para />
        ///     In case of a table, the matched sequence will be used as key and the table will tested for the key, if a value
        ///     exists it will be used as replacement.
        ///     <para />
        ///     In case of a function all matches will be passed as parameters to the function, the return value(s) of the function
        ///     will then be used as replacement.
        /// </param>
        /// <param name="maxReplaces">Maximum number of replacements to be made.</param>
        /// <returns>First result is replaced string. Second result is number of replaces.</returns>
        public static Tuple<string, uint> gsub(LuaState luaState, string input, string pattern, string replacement, uint maxReplaces = default(uint))
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(gsub));
                lua_pushstring(luaState, input);
                lua_pushstring(luaState, pattern);
                lua_pushstring(luaState, replacement);
                if (maxReplaces > default(uint))
                {
                    lua_pushnumber(luaState, maxReplaces);
                }
                else
                {
                    lua_pushnil(luaState);
                }
                lua_pcall(luaState, 4, 2);
                return new Tuple<string, uint>(ToManagedString(luaState), (uint)lua_tonumber(luaState, -2));
            }
        }

        /// <summary>
        ///     This functions main purpose is to replace certain character sequences in a string using
        ///     <see cref="http://wiki.garrysmod.com/page/Patterns">patterns</see>.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="replaceResult">Replaced string.</param>
        /// <param name="replaceCount">Number of replaces.</param>
        /// <param name="input">String which should be modified.</param>
        /// <param name="pattern">The pattern that defines what should be matched and eventually be replaced.</param>
        /// <param name="replacement">
        ///     In case of a string the matches sequence will be replaced with it.
        ///     <para />
        ///     In case of a table, the matched sequence will be used as key and the table will tested for the key, if a value
        ///     exists it will be used as replacement.
        ///     <para />
        ///     In case of a function all matches will be passed as parameters to the function, the return value(s) of the function
        ///     will then be used as replacement.
        /// </param>
        /// <param name="maxReplaces">Maximum number of replacements to be made.</param>
        public static void gsub(LuaState luaState, out string replaceResult, out uint replaceCount, string input, string pattern, string replacement, uint maxReplaces = default(uint))
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(gsub));
                lua_pushstring(luaState, input);
                lua_pushstring(luaState, pattern);
                lua_pushstring(luaState, replacement);
                if (maxReplaces > default(uint))
                {
                    lua_pushnumber(luaState, maxReplaces);
                }
                else
                {
                    lua_pushnil(luaState);
                }
                lua_pcall(luaState, 4, 2);
                replaceResult = ToManagedString(luaState);
                replaceCount = (uint)lua_tonumber(luaState, -2);
            }
        }

        // TODO: string.Implode (takes table as argument).

        /// <summary>
        ///     Escapes special characters for JavaScript in a string, making the string safe for inclusion in to JavaScript
        ///     strings.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string that should be escaped.</param>
        /// <returns>The escaped string.</returns>
        public static string JavascriptSafe(LuaState luaState, string inputString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(JavascriptSafe));
                lua_pushstring(luaState, inputString);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns everything left of supplied place of <paramref name="inputString" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to extract from.</param>
        /// <param name="num">Amount of chars relative to the beginning (starting from 1).</param>
        /// <returns>Returns a string containing a specified number of characters from the left side of a string.</returns>
        public static string Left(LuaState luaState, string inputString, uint num)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(Left));
                lua_pushstring(luaState, inputString);
                lua_pushnumber(luaState, num);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Counts the number of characters in the string (length).</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to find the length of.</param>
        /// <returns>Length of the <paramref name="inputString" />.</returns>
        public static uint len(LuaState luaState, string inputString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(len));
                lua_pushstring(luaState, inputString);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        /// <summary>Changes any upper-case letters in a <paramref name="inputString" /> to lower-case letters.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to convert.</param>
        /// <returns>A string representing the value of a <paramref name="inputString" /> converted to lower-case.</returns>
        public static string lower(LuaState luaState, string inputString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(lower));
                lua_pushstring(luaState, inputString);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>
        ///     Finds a <see cref="http://wiki.garrysmod.com/page/Patterns">pattern</see> in a <paramref name="inputString" />
        ///     .
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">String which should be searched in for matches.</param>
        /// <param name="pattern">The pattern that defines what should be matched.</param>
        /// <param name="startPosition">
        ///     The start index to start the matching from, can be negative to start the match from a
        ///     position relative to the end.
        /// </param>
        /// <returns>Matched text.</returns>
        public static string match(LuaState luaState, string inputString, string pattern, int startPosition)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(match));
                lua_pushstring(luaState, inputString);
                lua_pushstring(luaState, pattern);
                lua_pushnumber(luaState, startPosition);
                lua_pcall(luaState, 3, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Converts supplied number into bytes.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="bytes">The number to convert into bytes.</param>
        /// <returns>Nice string.</returns>
        public static string NiceSize(LuaState luaState, uint bytes)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(NiceSize));
                lua_pushnumber(luaState, bytes);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Converts supplied number into string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="seconds">The number to convert into string.</param>
        /// <returns>Nice string.</returns>
        public static string NiceTime(LuaState luaState, uint seconds)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(NiceTime));
                lua_pushnumber(luaState, seconds);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Escapes all special characters within a string, making the string safe for inclusion in a Lua pattern.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to be sanitized.</param>
        /// <returns>The string that has been sanitized for inclusion in Lua patterns.</returns>
        public static string PatternSafe(LuaState luaState, string inputString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(PatternSafe));
                lua_pushstring(luaState, inputString);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Repeats a string by the given value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to repeat.</param>
        /// <param name="repetitions">How many times to repeat.</param>
        /// <returns>Repeated <paramref name="inputString" />.</returns>
        public static string rep(LuaState luaState, string inputString, uint repetitions)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(rep));
                lua_pushstring(luaState, inputString);
                lua_pushnumber(luaState, repetitions);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Replaces all occurrences of the supplied second string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="input">The string we are seeking to replace an occurrence(s).</param>
        /// <param name="find">What we are seeking to replace.</param>
        /// <param name="replace">What to replace find with.</param>
        /// <returns>Replaced <paramref name="input" />.</returns>
        public static string Replace(LuaState luaState, string input, string find, string replace)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(Replace));
                lua_pushstring(luaState, input);
                lua_pushstring(luaState, find);
                lua_pushstring(luaState, replace);
                lua_pcall(luaState, 3, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Reverses a string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to be reversed.</param>
        /// <returns>Reversed <paramref name="input" />.</returns>
        public static string reverse(LuaState luaState, string inputString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(reverse));
                lua_pushstring(luaState, inputString);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the last n-th characters of the string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to extract from.</param>
        /// <param name="num">Amount of chars relative to the end (starting from 1).</param>
        /// <returns>Returns a string containing a specified number of characters from the right side of a string.</returns>
        public static string Right(LuaState luaState, string inputString, uint num)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(Right));
                lua_pushstring(luaState, inputString);
                lua_pushnumber(luaState, num);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Sets the character at the specific index of the string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The input string.</param>
        /// <param name="index">The character index, 1 is the first from left.</param>
        /// <param name="replacement">String to replace with.</param>
        /// <returns>Modified string.</returns>
        public static string SetChar(LuaState luaState, string inputString, uint index, char replacement)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(SetChar));
                lua_pushstring(luaState, inputString);
                lua_pushnumber(luaState, index);
                lua_pushstring(luaState, replacement.ToString());
                lua_pcall(luaState, 3, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: string.Split (returns a table).

        /// <summary>Returns whether or not the first string starts with the second.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">String to check.</param>
        /// <param name="startString">String to check with.</param>
        /// <returns>
        ///     True if <paramref name="inputString" /> starts with the <paramref name="startString" />, or
        ///     <paramref name="startString" /> is empty; otherwise false.
        /// </returns>
        public static bool StartWith(LuaState luaState, string inputString, string startString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(StartWith));
                lua_pushstring(luaState, inputString);
                lua_pushstring(luaState, startString);
                lua_pcall(luaState, 2, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Removes the extension of a path.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="fileName">The path to change.</param>
        /// <returns>Modified string.</returns>
        public static string StripExtension(LuaState luaState, string fileName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(StripExtension));
                lua_pushstring(luaState, fileName);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>
        ///     Returns a sub-string, starting from the character at position <paramref name="startPos" /> of the string
        ///     (inclusive), and optionally ending at the character at position <paramref name="endPos" /> of the string (also
        ///     inclusive). If <paramref name="endPos" /> is not given, the rest of the string is returned.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string you'll take a sub-string out of.</param>
        /// <param name="startPos">The position of the first character that will be included in the sub-string.</param>
        /// <param name="endPos">The position of the last character to be included in the sub-string.</param>
        /// <returns>The substring.</returns>
        public static string sub(LuaState luaState, string inputString, uint startPos, uint endPos = default(uint))
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(sub));
                lua_pushstring(luaState, inputString);
                lua_pushnumber(luaState, startPos);
                if (endPos > default(uint))
                {
                    lua_pushnumber(luaState, endPos);
                }
                else
                {
                    lua_pushnil(luaState);
                }
                lua_pcall(luaState, 3, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: string.ToColor (returns Color structure).

        /// <summary>Returns the given <paramref name="time" /> in "MM:SS" format.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="time">Time in seconds.</param>
        /// <returns>Formatted <paramref name="time" />.</returns>
        public static string ToMinutesSeconds(LuaState luaState, uint time)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(ToMinutesSeconds));
                lua_pushnumber(luaState, time);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the given <paramref name="time" /> in "MM:SS:MS" format.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="time">Time in seconds.</param>
        /// <returns>Formatted <paramref name="time" />.</returns>
        public static string ToMinutesSecondsMilliseconds(LuaState luaState, double time)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(ToMinutesSecondsMilliseconds));
                lua_pushnumber(luaState, time);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: string.ToTable (returns a table).

        /// <summary>Removes leading and trailing matches of a string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to trim.</param>
        /// <param name="match">String to match.</param>
        /// <returns>Trimmed string.</returns>
        public static string Trim(LuaState luaState, string inputString, string match = " ")
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(Trim));
                lua_pushstring(luaState, inputString);
                lua_pushstring(luaState, match);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Removes leading spaces/characters from a string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">String to trim.</param>
        /// <param name="match">Character to remove.</param>
        /// <returns>Trimmed string.</returns>
        public static string TrimLeft(LuaState luaState, string inputString, string match = " ")
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(TrimLeft));
                lua_pushstring(luaState, inputString);
                lua_pushstring(luaState, match);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Removes trailing spaces/passed character from a string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">String to remove from.</param>
        /// <param name="match">Character to remove.</param>
        /// <returns>Trimmed string.</returns>
        public static string TrimRight(LuaState luaState, string inputString, string match = " ")
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(TrimRight));
                lua_pushstring(luaState, inputString);
                lua_pushstring(luaState, match);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Changes any lower-case letters in a string to upper-case letters.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputString">The string to convert.</param>
        /// <returns>A string representing the value of a string converted to upper-case.</returns>
        public static string upper(LuaState luaState, string inputString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(@string));
                lua_getfield(luaState, -1, nameof(upper));
                lua_pushstring(luaState, inputString);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }
    }
}