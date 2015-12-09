namespace GarrysModLuaShared.Enums
{
    public enum CAP
    {
        CAP_SIMPLE_RADIUS_DAMAGE = -2147483648,

        /// <summary>Walk/Run</summary>
        CAP_MOVE_GROUND = 1,

        /// <summary>Jump/Leap</summary>
        CAP_MOVE_JUMP = 2,

        /// <summary>Can fly move all around</summary>
        CAP_MOVE_FLY = 4,

        /// <summary>climb ladders</summary>
        CAP_MOVE_CLIMB = 8,
        CAP_MOVE_SWIM = 16,
        CAP_MOVE_CRAWL = 32,

        /// <summary>Tries to shoot weapon while moving</summary>
        CAP_MOVE_SHOOT = 64,
        CAP_SKIP_NAV_GROUND_CHECK = 128,

        /// <summary>Open doors/push buttons/pull levers</summary>
        CAP_USE = 256,

        /// <summary>Can trigger auto doors</summary>
        CAP_AUTO_DOORS = 1024,

        /// <summary>Can open manual doors</summary>
        CAP_OPEN_DOORS = 2048,

        /// <summary>Can turn head always bone controller 0</summary>
        CAP_TURN_HEAD = 4096,
        CAP_WEAPON_RANGE_ATTACK1 = 8192,
        CAP_WEAPON_RANGE_ATTACK2 = 16384,
        CAP_WEAPON_MELEE_ATTACK1 = 32768,
        CAP_WEAPON_MELEE_ATTACK2 = 65536,
        CAP_INNATE_RANGE_ATTACK1 = 131072,
        CAP_INNATE_RANGE_ATTACK2 = 262144,
        CAP_INNATE_MELEE_ATTACK1 = 524288,
        CAP_INNATE_MELEE_ATTACK2 = 1048576,
        CAP_USE_WEAPONS = 2097152,
        CAP_USE_SHOT_REGULATOR = 16777216,

        /// <summary>Has animated eyes/face</summary>
        CAP_ANIMATEDFACE = 8388608,

        /// <summary>Don't take damage from npc's that are D_LI</summary>
        CAP_FRIENDLY_DMG_IMMUNE = 33554432,

        /// <summary>Can form squads</summary>
        CAP_SQUAD = 67108864,

        /// <summary>Cover and Reload ducking</summary>
        CAP_DUCK = 134217728,

        /// <summary>Don't hit players</summary>
        CAP_NO_HIT_PLAYER = 268435456,

        /// <summary>Use arms to aim gun, not just body</summary>
        CAP_AIM_GUN = 536870912,
        CAP_NO_HIT_SQUADMATES = 1073741824
    }
}