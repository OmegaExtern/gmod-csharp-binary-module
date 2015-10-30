#if CLIENT
namespace GarrysModLuaShared.Classes
{
    /// <summary>This is the object passed to <see cref="usermessage.Hook"/> when a message is received. It contains each value stored in the message in sequential order. You should read values from it in the order you wrote them.</summary>
    public sealed class bf_read : LuaObject
    {
        static readonly int bf_readId = Random.Generator.Next((int)Type.UserMsg, int.MaxValue);

        public bf_read(int index) : base(index)
        {}

        /// <summary>Reads an returns an angle object from the bitstream.</summary>
        /// <returns>The read angle.</returns>
        public Angle ReadAngle() => CallObject(nameof(ReadAngle)).ToAngle();

        /// <summary>Reads 1 bit an returns a bool representing the bit.</summary>
        /// <returns>The read bit as boolean.</returns>
        public bool ReadBool() => CallBoolean(nameof(ReadBool));

        /// <summary>Reads a signed char and returns a number from -127 to 127 representing the ascii value of that char.</summary>
        /// <returns>ASCII value.</returns>
        public sbyte ReadChar() => (sbyte)CallInteger(nameof(ReadChar));

        /// <summary>Reads a short representing an entity index and returns the matching entity handle.</summary>
        /// <returns>The read entity.</returns>
        public Entity ReadEntity() => CallObject(nameof(ReadEntity)).ToEntity();

        /// <summary>Reads a 4 byte float from the bitstream and returns it.</summary>
        /// <returns>The read float.</returns>
        public double ReadFloat() => CallNumber(nameof(ReadFloat));

        /// <summary>Reads a 4 byte long from the bitstream and returns it.</summary>
        /// <returns>The read long.</returns>
        public int ReadLong() => CallInteger(nameof(ReadLong));

        /// <summary>Reads a 2 byte short from the bitstream and returns it.</summary>
        /// <returns>The read short.</returns>
        public short ReadShort() => (short)CallInteger(nameof(ReadShort));

        /// <summary>Reads a null terminated string from the bitstream.</summary>
        /// <returns>The read string.</returns>
        public string ReadString() => CallString(nameof(ReadString));

        /// <summary>Reads a special encoded vector from the bitstream and returns it, this function is not suitable to send normals.</summary>
        /// <returns>The read vector.</returns>
        public Vector ReadVector() => CallObject(nameof(ReadVector)).ToVector();

        /// <summary>Reads a special encoded vector normal from the bitstream and returns it, this function is not suitable to send vectors that represent a position.</summary>
        /// <returns>The read normal vector.</returns>
        public Vector ReadVectorNormal() => CallObject(nameof(ReadVectorNormal)).ToVector();

        /// <summary>Rewinds the bitstream so it can be read again.</summary>
        public void Reset() => CallVoid(nameof(Reset));
    }
}
#endif