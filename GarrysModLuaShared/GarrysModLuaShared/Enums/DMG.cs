namespace GarrysModLuaShared.Enums
{
    public enum DMG
    {
        /// <summary>Generic damage</summary>
        DMG_GENERIC = 0,
        /// <summary>Caused by physics interaction</summary>
        DMG_CRUSH = 1,
        /// <summary>Bullet damage</summary>
        DMG_BULLET = 2,
        /// <summary>Sharp objects, such as Manhacks or other NPCs attacks</summary>
        DMG_SLASH = 4,
        /// <summary>Damage from fire</summary>
        DMG_BURN = 8,
        /// <summary>Hit by a vehicle</summary>
        DMG_VEHICLE = 16,
        /// <summary>Fall damage</summary>
        DMG_FALL = 32,
        /// <summary>Explosion damage</summary>
        DMG_BLAST = 64,
        /// <summary>Crowbar damage</summary>
        DMG_CLUB = 128,
        /// <summary>Electrical damage, shows smoke at the damage position</summary>
        DMG_SHOCK = 256,
        /// <summary>Sonic damage,used by the Gargantua and Houndeye NPCs</summary>
        DMG_SONIC = 512,
        /// <summary>Laser</summary>
        DMG_ENERGYBEAM = 1024,
        /// <summary>Don't create gibs</summary>
        DMG_NEVERGIB = 4096,
        /// <summary>Always create gibs</summary>
        DMG_ALWAYSGIB = 8192,
        /// <summary>Drown damage</summary>
        DMG_DROWN = 16384,
        /// <summary>Same as DMG_POISON</summary>
        DMG_PARALYZE = 32768,
        /// <summary>Neurotoxin damage</summary>
        DMG_NERVEGAS = 65536,
        /// <summary>Poison damage</summary>
        DMG_POISON = 131072,
        /// <summary>Toxic chemicals or acid burns</summary>
        DMG_ACID = 1048576,
        /// <summary>Airboat gun damage</summary>
        DMG_AIRBOAT = 33554432,
        /// <summary>This won't hurt the player underwater</summary>
        DMG_BLAST_SURFACE = 134217728,
        /// <summary>The pellets fired from a shotgun</summary>
        DMG_BUCKSHOT = 536870912,
        /// <summary>Direct damage to the entity that does not go through any damage value modifications</summary>
        DMG_DIRECT = 268435456,
        /// <summary>Forces the entity to dissolve on death</summary>
        DMG_DISSOLVE = 67108864,
        /// <summary>Damage applied to the player to restore health after drowning</summary>
        DMG_DROWNRECOVER = 524288,
        /// <summary>Damage done by the gravity gun</summary>
        DMG_PHYSGUN = 8388608,
        /// <summary>Plasma</summary>
        DMG_PLASMA = 16777216,
        /// <summary>Prevent a physics force</summary>
        DMG_PREVENT_PHYSICS_FORCE = 2048,
        /// <summary>Radiation</summary>
        DMG_RADIATION = 262144,
        /// <summary>Don't create a ragdoll on death</summary>
        DMG_REMOVENORAGDOLL = 4194304,
        /// <summary>In an oven</summary>
        DMG_SLOWBURN = 2097152
    }
}