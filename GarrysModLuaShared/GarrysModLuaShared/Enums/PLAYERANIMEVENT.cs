namespace GarrysModLuaShared.Enums
{
    public enum PLAYERANIMEVENT
    {
        PLAYERANIMEVENT_ATTACK_GRENADE = 2,
        /// <summary>Primary attack</summary>
        PLAYERANIMEVENT_ATTACK_PRIMARY = 0,
        /// <summary>Secondary attack</summary>
        PLAYERANIMEVENT_ATTACK_SECONDARY = 1,
        PLAYERANIMEVENT_CANCEL = 16,
        /// <summary>Used to play specific activities</summary>
        PLAYERANIMEVENT_CUSTOM = 19,
        PLAYERANIMEVENT_CUSTOM_GESTURE = 20,
        PLAYERANIMEVENT_CUSTOM_GESTURE_SEQUENCE = 22,
        /// <summary>Used to play specific sequences</summary>
        PLAYERANIMEVENT_CUSTOM_SEQUENCE = 21,
        PLAYERANIMEVENT_DIE = 8,
        PLAYERANIMEVENT_DOUBLEJUMP = 15,
        PLAYERANIMEVENT_FLINCH_CHEST = 9,
        PLAYERANIMEVENT_FLINCH_HEAD = 10,
        PLAYERANIMEVENT_FLINCH_LEFTARM = 11,
        PLAYERANIMEVENT_FLINCH_LEFTLEG = 13,
        PLAYERANIMEVENT_FLINCH_RIGHTARM = 12,
        PLAYERANIMEVENT_FLINCH_RIGHTLEG = 14,
        /// <summary>Jump</summary>
        PLAYERANIMEVENT_JUMP = 6,
        /// <summary>Reload</summary>
        PLAYERANIMEVENT_RELOAD = 3,
        PLAYERANIMEVENT_RELOAD_END = 5,
        PLAYERANIMEVENT_RELOAD_LOOP = 4,
        /// <summary>Snap to current yaw exactly</summary>
        PLAYERANIMEVENT_SNAP_YAW = 18,
        PLAYERANIMEVENT_SPAWN = 17,
        PLAYERANIMEVENT_SWIM = 7
    }
}