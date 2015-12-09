using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The bitwise library contains useful functions for bitwise operations.</summary>
    static class bit
    {
        /// <summary>Returns the arithmetically shifted value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be manipulated.</param>
        /// <param name="shiftCount">Amount of bits to shift.</param>
        /// <returns>Shifted value.</returns>
        public static double arshift(LuaState luaState, double value, double shiftCount)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(arshift));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, shiftCount);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the bitwise and of all values specified.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be manipulated.</param>
        /// <param name="otherValues">Values to bit and with. Optional.</param>
        /// <returns>Bitwise And.</returns>
        public static double band(LuaState luaState, double value, params double[] otherValues)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(band));
                lua_pushnumber(luaState, value);
                int len = default(int);
                for (int i = 0; i < otherValues.Length; ++i)
                {
                    lua_pushnumber(luaState, i);
                    len++;
                }
                lua_pcall(luaState, 1 + len, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the bitwise not of the <paramref name="value" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be inverted.</param>
        /// <returns>Bitwise Not.</returns>
        public static double bnot(LuaState luaState, double value)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(bnot));
                lua_pushnumber(luaState, value);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the bitwise OR of all values specified.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The first value.</param>
        /// <param name="otherValues">Extra values to be evaluated. Optional.</param>
        /// <returns>The bitwise OR result between all numbers.</returns>
        public static double bor(LuaState luaState, double value, params double[] otherValues)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(bor));
                lua_pushnumber(luaState, value);
                int len = default(int);
                for (int i = 0; i < otherValues.Length; ++i)
                {
                    lua_pushnumber(luaState, i);
                    len++;
                }
                lua_pcall(luaState, 1 + len, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Swaps the byte order.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be byte swapped.</param>
        /// <returns>Number with swapped byte order of the given <paramref name="value" />.</returns>
        public static double bswap(LuaState luaState, double value)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(bswap));
                lua_pushnumber(luaState, value);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the bitwise xor of all values specified.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be manipulated.</param>
        /// <param name="otherValues">Values to bit xor with. Optional.</param>
        /// <returns>Bitwise XOR.</returns>
        public static double bxor(LuaState luaState, double value, params double[] otherValues)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(bxor));
                lua_pushnumber(luaState, value);
                int len = default(int);
                for (int i = 0; i < otherValues.Length; ++i)
                {
                    lua_pushnumber(luaState, i);
                    len++;
                }
                lua_pcall(luaState, 1 + len, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the left shifted value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be manipulated.</param>
        /// <param name="shiftCount">Amount of bits to shift left by.</param>
        /// <returns>Shifted value.</returns>
        public static double lshift(LuaState luaState, double value, double shiftCount)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(lshift));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, shiftCount);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the left rotated value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be manipulated.</param>
        /// <param name="shiftCount">Amount of bits to rotate left by.</param>
        /// <returns>Shifted value.</returns>
        public static double rol(LuaState luaState, double value, double shiftCount)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(rol));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, shiftCount);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the right rotated value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be manipulated.</param>
        /// <param name="shiftCount">Amount of bits to rotate right by.</param>
        /// <returns>Shifted value.</returns>
        public static double ror(LuaState luaState, double value, double shiftCount)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(ror));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, shiftCount);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the right shifted value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be manipulated.</param>
        /// <param name="shiftCount">Amount of bits to shift right by.</param>
        /// <returns>Shifted value.</returns>
        public static double rshift(LuaState luaState, double value, double shiftCount)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(rshift));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, shiftCount);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Normalizes the specified value and clamps it in the range of a signed 32bit integer.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be normalized.</param>
        /// <returns>Normalized value.</returns>
        public static double tobit(LuaState luaState, double value)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(tobit));
                lua_pushnumber(luaState, value);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the hexadecimal representation of the number with the specified digits.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to be converted.</param>
        /// <param name="digits">The number of digits. Optional.</param>
        /// <returns>Hexadecimal string.</returns>
        public static string tohex(LuaState luaState, double value, double digits = 8)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(bit));
                lua_getfield(luaState, -1, nameof(tohex));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, digits);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }
    }
}