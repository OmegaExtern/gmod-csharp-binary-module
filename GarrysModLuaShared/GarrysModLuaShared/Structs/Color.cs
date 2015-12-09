using System.Runtime.InteropServices;

namespace GarrysModLuaShared.Structs
{
    /// <summary>Object returned by the <see cref="Global.Color" /> function and used in various situations.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Color
    {
        /// <summary>The red channel.</summary>
        public byte r;

        /// <summary>The blue channel.</summary>
        public byte b;

        /// <summary>The alpha channel (transparency).</summary>
        public byte a;

        /// <summary>The green channel.</summary>
        public byte g;
    }
}