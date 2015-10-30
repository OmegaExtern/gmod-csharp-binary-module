namespace GarrysModLuaShared.Classes
{
    /// <summary>Representation of a line with direction and length. Use <see cref="Global.Vector"/> function to create an instance of this object.</summary>
    public sealed class Vector : LuaObject
    {
        public Vector(int index) : base(index)
        {}

        public Vector(double x, double y, double z) : base(LuaTable._G.InvokeObject(nameof(Vector), x, y, z).GetIndex())
        {}

        /// <summary>The X component of the vector (+forward/-backward; East/West).</summary>
        public double x
        {
            get
            {
                return GetFieldNumber(nameof(x));
            }
            set
            {
                SetField(nameof(x), value);
            }
        }

        /// <summary>The Y component of the vector (+left/-right; North/South).</summary>
        public double y
        {
            get
            {
                return GetFieldNumber(nameof(y));
            }
            set
            {
                SetField(nameof(y), value);
            }
        }

        /// <summary>The Z component of the vector (+up/-down).</summary>
        public double z
        {
            get
            {
                return GetFieldNumber(nameof(z));
            }
            set
            {
                SetField(nameof(z), value);
            }
        }
    }
}