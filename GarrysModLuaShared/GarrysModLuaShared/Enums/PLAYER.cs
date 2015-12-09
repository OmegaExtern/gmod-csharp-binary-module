namespace GarrysModLuaShared.Enums
{
    public enum PLAYER
    {
        PLAYER_IDLE = 0,
        PLAYER_WALK = 1,
        PLAYER_JUMP = 2,
        PLAYER_SUPERJUMP = 3,
        PLAYER_DIE = 4,

        /// <summary>Player attack according to current hold type, used in SWEPs</summary>
        PLAYER_ATTACK1 = 5,
        PLAYER_IN_VEHICLE = 6,
        PLAYER_RELOAD = 7,
        PLAYER_START_AIMING = 8,
        PLAYER_LEAVE_AIMING = 9
    }
}