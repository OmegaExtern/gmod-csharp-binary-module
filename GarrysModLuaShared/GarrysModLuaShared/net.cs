using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The net library is one of a number of ways to send data between the client and server.<para/>The major advantages of the net library are the large size limit(64kb/message) and the ability to send data backwards - from the client to the server.</summary>
    static class net
    {
#if SERVER
        /// <summary>Sends the currently built net message to all connected players.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void Broadcast(IntPtr luaState)
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
        public static double BytesWritten(IntPtr luaState)
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

        public static double ReadBit(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadBit));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static bool ReadBool(IntPtr luaState)
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

        public static string ReadData(IntPtr luaState, double length)
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

        public static double ReadDouble(IntPtr luaState)
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

        public static double ReadFloat(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadFloat));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static double ReadHeader(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(ReadHeader));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        public static int ReadInt(IntPtr luaState, double bitCount = 32.0D)
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

        public static string ReadString(IntPtr luaState)
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

        public static uint ReadUInt(IntPtr luaState, double bitCount = 32.0D)
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

        //#if CLIENT
        public static void SendToServer(IntPtr luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(SendToServer));
                lua_pcall(luaState);
            }
        }
        //#endif

        public static bool Start(IntPtr luaState, string messageName, bool unreliable = false)
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

        public static void WriteBit(IntPtr luaState, bool boolean)
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

        public static void WriteData(IntPtr luaState, string binaryData, double length)
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

        public static void WriteDouble(IntPtr luaState, double @double)
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

        public static void WriteFloat(IntPtr luaState, double @float)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(net));
                lua_getfield(luaState, -1, nameof(WriteFloat));
                lua_pushnumber(luaState, @float);
                lua_pcall(luaState, 1);
            }
        }

        public static void WriteInt(IntPtr luaState, int integer, double bitCount = 32.0D)
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

        public static void WriteString(IntPtr luaState, string @string)
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

        public static void WriteUInt(IntPtr luaState, uint unsignedInteger, double numberOfBits = 32.0D)
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