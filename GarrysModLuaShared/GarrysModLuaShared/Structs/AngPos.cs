using System.Runtime.InteropServices;
using GarrysModLuaShared.Classes;

namespace GarrysModLuaShared.Structs
{
    /// <summary>Structure used by various functions, such as <see cref="Entity.GetAttachment"/>.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AngPos
    {
        /// <summary>Angle object.</summary>
        public Angle Ang;

        /// <summary>Vector object.</summary>
        public Vector Pos;
    }
}