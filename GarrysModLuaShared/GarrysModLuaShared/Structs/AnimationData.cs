using System.ComponentModel;
using System.Runtime.InteropServices;
using GarrysModLuaShared.Classes;

namespace GarrysModLuaShared.Structs
{
    /// <summary>Structure used by panel animation methods, primarily <see cref="Panel.AnimationThinkInternal"/>, and returned by <see cref="Panel.NewAnimation"/>.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AnimationData
    {
        /// <summary>The system time value returned by <see cref="Global.SysTime"/> when the animation starts/will start.</summary>
        public double StartTime;

        /// <summary>The system time value returned by <see cref="Global.SysTime"/> when the animation ends/will end.</summary>
        public double EndTime;

        /// <summary>The ease in/out level of the animation.</summary>
        [DefaultValue(-1.0D)]
        public double Ease;
    }
}