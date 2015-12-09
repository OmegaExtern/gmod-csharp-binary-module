using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>
    ///     The net library is one of a number of ways to send data between the client and server.
    ///     <para />
    ///     The major advantages of the net library are the large size limit(64kb/message) and the ability to send data
    ///     backwards - from the client to the server.
    /// </summary>
    static class net
    {
#if SERVER
        /// <summary>Sends the currently built net message to all connected players.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void Broadcast(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(Broadcast));
                lua_pcall(luaState);
            }
        }
#endif

        /// <summary>Returns the size of the current message in bytes.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The size of the current message in bytes.</returns>
        public static double BytesWritten(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(BytesWritten));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        // TODO: net.Incoming (takes Entity type as argument).

        // TODO: net.ReadAngle (returns Angle structure).

        /// <summary>Reads a bit from the received net message.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>0 or 1.</returns>
        public static double ReadBit(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadBit));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Reads a boolean from the received net message.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>false or true.</returns>
        public static bool ReadBool(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadBool));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        // TODO: net.ReadColor (returns Color structure).

        /// <summary>
        ///     Reads pure binary data from the message.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="length">
        ///     The length of the data to be read, in bytes.
        ///     <para />
        ///     When this is 0, <see cref="ReadData" /> does not return an empty string as you would expect, but random junk
        ///     instead.
        /// </param>
        /// <returns>The binary data read.</returns>
        public static string ReadData(LuaState luaState, double length)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadData));
                lua_pushnumber(luaState, length);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Reads a double-precision number from the received net message.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The double-precision number.</returns>
        public static double ReadDouble(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadDouble));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        // TODO: net.ReadEntity (returns Entity type).

        /// <summary>Reads a floating-point number from the received net message.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The floating-point number.</returns>
        public static float ReadFloat(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadFloat));
                lua_pcall(luaState, 0, 1);
                return (float)lua_tonumber(luaState);
            }
        }

        /// <summary>
        ///     Returns the "header" of the message which contains a short which can be converted to the corresponding message
        ///     name via <see cref="util.NetworkIDToString" />.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The header number.</returns>
        public static double ReadHeader(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadHeader));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Reads an integer from the received net message.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="bitCount">The amount of bits to be read.</param>
        /// <returns>The read integer number.</returns>
        public static int ReadInt(LuaState luaState, double bitCount = 32.0D)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadInt));
                lua_pushnumber(luaState, bitCount);
                lua_pcall(luaState, 1, 1);
                return lua_tointeger(luaState);
            }
        }

        // TODO: net.ReadNormal (returns Vector structure).

        /// <summary>
        ///     Reads a null terminated string from the net stream. The size of the string is 8 bits plus 8 bits for every
        ///     ASCII character in the string.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The read string.</returns>
        public static string ReadString(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadString));
                lua_pcall(luaState, 0, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: net.ReadTable (returns a table).

        // TODO: net.ReadType (returns any type).

        /// <summary>Reads an unsigned integer with the specified number of bits from the received net message.
        ///     <para />
        ///     Warning! You must read information in same order as you write it.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="bitCount">The size of the integer to be read, in bits.</param>
        /// <returns>The unsigned integer read.</returns>
        public static uint ReadUInt(LuaState luaState, double bitCount = 32.0D)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadUInt));
                lua_pushnumber(luaState, bitCount);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        // TODO: net.ReadVector (returns Vector structure).

        // TODO: net.Receive (takes function as argument).

        //#if SERVER
        // TODO: net.Send (takes a Player or table/array of Player objects as argument).

        // TODO: net.SendOmit (takes a Player or table/array of Player objects as argument).

        // TODO: net.SendPAS (takes a Vector as argument).

        // TODO: net.SendPVS (takes a Vector as argument).
        //#endif

#if CLIENT
        /// <summary>Sends the current message to the server.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void SendToServer(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(SendToServer));
                lua_pcall(luaState);
            }
        }
#endif

        /// <summary>Begins a new net message.
        ///     <para />
        ///     Don't forget to pool the <paramref name="messageName" /> with <see cref="util.AddNetworkString" />!
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="messageName">The name of the message to send.</param>
        /// <param name="unreliable">If set to true, the message is not guaranteed to reach its destination.</param>
        /// <returns>True if the message has been started.</returns>
        public static bool Start(LuaState luaState, string messageName, bool unreliable = false)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(Start));
                lua_pushstring(luaState, messageName);
                lua_pushboolean(luaState, unreliable);
                lua_pcall(luaState, 2, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        // TODO: net.WriteAngle (takes Angle structure as argument).

        /// <summary>Appends a boolean (as 0 or 1) to the current net message.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="boolean">Bit status (false = 0, true = 1) to be sent.</param>
        public static void WriteBit(LuaState luaState, bool boolean)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteBit));
                lua_pushboolean(luaState, boolean);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: net.WriteColor (takes Color structure as argument).

        /// <summary>Writes a chunk of binary data to the message.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="binaryData">The binary data to be sent.</param>
        /// <param name="length">The length of the binary data to be sent, in bytes.</param>
        public static void WriteData(LuaState luaState, string binaryData, double length)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteData));
                lua_pushstring(luaState, binaryData);
                lua_pushnumber(luaState, length);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Appends a double-precision number to the current net message.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="double">The double to be sent.</param>
        public static void WriteDouble(LuaState luaState, double @double)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteDouble));
                lua_pushnumber(luaState, @double);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: net.WriteEntity (takes Entity type as argument).

        /// <summary>Appends a float (number with decimals) to the current net message.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="float">The float to be sent.</param>
        public static void WriteFloat(LuaState luaState, float @float)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteFloat));
                lua_pushnumber(luaState, @float);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Appends an integer (number without decimals) to the current net message.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="integer">The integer to be sent.</param>
        /// <param name="bitCount">
        ///     The amount of bits the number consists of. (signed)
        ///     <para />
        ///     This must be 32 or less. If you are unsure what to set, just set it to 32.
        ///     <para />
        ///     To determine just how many bits exactly you're going to need for your integer, you first need to understand what
        ///     those bits actually are. A bit can have two possible states: 0 and 1. For every bit you add, you get an
        ///     exponentially increasing amount of possible combinations. 2 bits allow for 2^2 = 4 possible combinations (namely
        ///     00, 01, 10 and 11), 3 bits allow for 2^3 = 8 possible combinations, 4 bits allow for 2^4 = 16 possible combinations
        ///     and so on. Since we start counting from 0, a 4-bit integer would thus be able to represent any integer number
        ///     between 0 and 15.
        ///     <para />
        ///     Do note that Garry's Mod is using the first bit for purposes other than storing your integer's value. Just figure
        ///     out how many bits you'd normally need, then increase that number by one (so if you want to send an integer that may
        ///     assume any number between 0 and 15, you don't use a 4 as your bitCount but rather a 5).
        ///     <para />
        ///     Consult <see cref="http://www.exploringbinary.com/a-table-of-nonnegative-powers-of-two/">this table</see> for a
        ///     quick reference on how many bits you need for a given value.
        /// </param>
        public static void WriteInt(LuaState luaState, int integer, double bitCount = 32.0D)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteInt));
                lua_pushinteger(luaState, integer);
                lua_pushnumber(luaState, bitCount);
                lua_pcall(luaState, 2);
            }
        }

        // TODO: net.WriteNormal (takes Vector structure as argument).

        /// <summary>
        ///     Appends a string to the current net message. The size of the string is 8 bits plus 8 bits for every ASCII
        ///     character in the string. The maximum allowed length of a single written string is 1024 characters.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="string">The string to be sent.</param>
        public static void WriteString(LuaState luaState, string @string)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteString));
                lua_pushstring(luaState, @string);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: net.WriteTable (takes a table as argument).

        // TODO: net.WriteType (takes any type as argument).

        /// <summary>Appends an unsigned integer with the specified number of bits to the current net message.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="unsignedInteger">The unsigned integer to be sent.</param>
        /// <param name="numberOfBits">
        ///     The size of the integer to be sent, in bits. Acceptable values range from 1 to 32. 1 = bit,
        ///     4 = nibble, 8 = byte, 16 = short, 32 = long.
        /// </param>
        public static void WriteUInt(LuaState luaState, uint unsignedInteger, double numberOfBits = 32.0D)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteUInt));
                lua_pushnumber(luaState, unsignedInteger);
                lua_pushnumber(luaState, numberOfBits);
                lua_pcall(luaState, 2);
            }
        }

        // TODO: net.WriteVector (takes Vector structure as argument).
    }
}