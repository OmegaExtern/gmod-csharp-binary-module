using System.ComponentModel;
using System.Runtime.InteropServices;
using GarrysModLuaShared.Enums;

namespace GarrysModLuaShared.Structs
{
    /// <summary>Structure used for bullets, see <see cref="game.AddAmmoType"/>.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AmmoData
    {
        /// <summary>Damage type.</summary>
        [DefaultValue(DMG.DMG_BULLET)]
        public DMG dmgtype;

        /// <summary>The force of the ammo.</summary>
        [DefaultValue(1000.0D)]
        public double force;

        /// <summary>The maximum splash.</summary>
        [DefaultValue(0.0D)]
        public double maxsplash;

        /// <summary>The minimum splash.</summary>
        [DefaultValue(0.0D)]
        public double minsplash;

        /// <summary>Name of the ammo.</summary>
        [DefaultValue("MissingName")]
        public string name;

        /// <summary>The damage dealt to NPCs.</summary>
        [DefaultValue(10.0D)]
        public double npcdmg;

        /// <summary>The damage dealt to players.</summary>
        [DefaultValue(10.0D)]
        public double plydmg;

        /// <summary>Tracer type.</summary>
        [DefaultValue(TRACER.TRACER_NONE)]
        public TRACER tracer;

        /// <summary>Maximum amount of ammo of this type the player should be able to carry in reserve.<para/>NOTE: Currently only affects <see cref="game.GetAmmoMax"/>.</summary>
        [DefaultValue(9999.0D)]
        public double maxcarry;

        /// <summary>Flags for the ammo type.</summary>
        [DefaultValue(0.0D)]
        public double flags;
    }
}