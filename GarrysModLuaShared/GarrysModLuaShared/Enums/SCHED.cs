namespace GarrysModLuaShared.Enums
{
    public enum SCHED
    {
        /// <summary>The schedule enum limit</summary>
        LAST_SHARED_SCHEDULE = 88,
        /// <summary>Begins AI script based on NPC's m_hCine save value.</summary>
        SCHED_AISCRIPT = 56,
        /// <summary>Idle stance and face ideal yaw angles.</summary>
        SCHED_ALERT_FACE = 5,
        SCHED_ALERT_FACE_BESTSOUND = 6,
        SCHED_ALERT_REACT_TO_COMBAT_SOUND = 7,
        /// <summary>Rotate 180 degrees and back to check for enemies.</summary>
        SCHED_ALERT_SCAN = 8,
        /// <summary>Remain idle until an enemy is heard or found.</summary>
        SCHED_ALERT_STAND = 9,
        /// <summary>Walk until an enemy is heard or found.</summary>
        SCHED_ALERT_WALK = 10,
        /// <summary>Remain idle until provoked or an enemy is found.</summary>
        SCHED_AMBUSH = 52,
        /// <summary>Performs ACT_ARM.</summary>
        SCHED_ARM_WEAPON = 48,
        /// <summary>Back away from enemy. If not possible to back away then go behind enemy.</summary>
        SCHED_BACK_AWAY_FROM_ENEMY = 24,
        SCHED_BACK_AWAY_FROM_SAVE_POSITION = 26,
        /// <summary>Heavy damage was taken for the first time in a while.</summary>
        SCHED_BIG_FLINCH = 23,
        /// <summary>Begin chasing an enemy.</summary>
        SCHED_CHASE_ENEMY = 17,
        SCHED_CHASE_ENEMY_FAILED = 18,
        SCHED_COMBAT_FACE = 12,
        SCHED_COMBAT_PATROL = 75,
        SCHED_COMBAT_STAND = 15,
        SCHED_COMBAT_SWEEP = 13,
        SCHED_COMBAT_WALK = 16,
        /// <summary>When not moving, will perform ACT_COWER.</summary>
        SCHED_COWER = 40,
        /// <summary>Regular NPC death.</summary>
        SCHED_DIE = 53,
        /// <summary>Plays NPC death sound (doesn't kill NPC).</summary>
        SCHED_DIE_RAGDOLL = 54,
        SCHED_DISARM_WEAPON = 49,
        SCHED_DROPSHIP_DUSTOFF = 79,
        SCHED_DUCK_DODGE = 84,
        SCHED_ESTABLISH_LINE_OF_FIRE = 35,
        SCHED_ESTABLISH_LINE_OF_FIRE_FALLBACK = 36,
        SCHED_FAIL = 81,
        SCHED_FAIL_ESTABLISH_LINE_OF_FIRE = 38,
        SCHED_FAIL_NOSTOP = 82,
        SCHED_FAIL_TAKE_COVER = 31,
        SCHED_FALL_TO_GROUND = 78,
        SCHED_FEAR_FACE = 14,
        SCHED_FLEE_FROM_BEST_SOUND = 29,
        /// <summary>Plays ACT_FLINCH_PHYSICS.</summary>
        SCHED_FLINCH_PHYSICS = 80,
        /// <summary>Force walk to position (debug).</summary>
        SCHED_FORCED_GO = 71,
        /// <summary>Force run to position (debug).</summary>
        SCHED_FORCED_GO_RUN = 72,
        /// <summary>Pick up item if within a radius of 5 units.</summary>
        SCHED_GET_HEALTHKIT = 66,
        SCHED_HIDE_AND_RELOAD = 50,
        /// <summary>Idle stance</summary>
        SCHED_IDLE_STAND = 1,
        /// <summary>Walk to position.</summary>
        SCHED_IDLE_WALK = 2,
        /// <summary>Walk to random position within a radius of 200 units.</summary>
        SCHED_IDLE_WANDER = 3,
        SCHED_INTERACTION_MOVE_TO_PARTNER = 85,
        SCHED_INTERACTION_WAIT_FOR_PARTNER = 86,
        SCHED_INVESTIGATE_SOUND = 11,
        SCHED_MELEE_ATTACK1 = 41,
        SCHED_MELEE_ATTACK2 = 42,
        /// <summary>Move away from player.</summary>
        SCHED_MOVE_AWAY = 68,
        /// <summary>Stop moving and continue enemy scan.</summary>
        SCHED_MOVE_AWAY_END = 70,
        /// <summary>Failed to move away; stop moving.</summary>
        SCHED_MOVE_AWAY_FAIL = 69,
        /// <summary>Move away from enemy while facing it and checking for new enemies.</summary>
        SCHED_MOVE_AWAY_FROM_ENEMY = 25,
        SCHED_MOVE_TO_WEAPON_RANGE = 34,
        /// <summary>Pick up a new weapon if within a radius of 5 units.</summary>
        SCHED_NEW_WEAPON = 63,
        /// <summary>Fail safe: Create the weapon that the NPC went to pick up if it was removed during pick up schedule.</summary>
        SCHED_NEW_WEAPON_CHEAT = 64,
        /// <summary>No schedule is being performed.</summary>
        SCHED_NONE = 0,
        /// <summary>Prevents movement until COND_NPC_UNFREEZE(68) is set.</summary>
        SCHED_NPC_FREEZE = 73,
        /// <summary>Run to random position and stop if enemy is heard or found.</summary>
        SCHED_PATROL_RUN = 76,
        /// <summary>Walk to random position and stop if enemy is heard or found.</summary>
        SCHED_PATROL_WALK = 74,
        SCHED_PRE_FAIL_ESTABLISH_LINE_OF_FIRE = 37,
        SCHED_RANGE_ATTACK1 = 43,
        SCHED_RANGE_ATTACK2 = 44,
        /// <summary>Stop moving and reload until danger is heard.</summary>
        SCHED_RELOAD = 51,
        SCHED_RUN_FROM_ENEMY = 32,
        SCHED_RUN_FROM_ENEMY_FALLBACK = 33,
        SCHED_RUN_FROM_ENEMY_MOB = 83,
        /// <summary>Run to random position within a radius of 500 units.</summary>
        SCHED_RUN_RANDOM = 77,
        SCHED_SCENE_GENERIC = 62,
        SCHED_SCRIPTED_CUSTOM_MOVE = 59,
        SCHED_SCRIPTED_FACE = 61,
        SCHED_SCRIPTED_RUN = 58,
        SCHED_SCRIPTED_WAIT = 60,
        SCHED_SCRIPTED_WALK = 57,
        SCHED_SHOOT_ENEMY_COVER = 39,
        SCHED_SLEEP = 87,
        SCHED_SMALL_FLINCH = 22,
        SCHED_SPECIAL_ATTACK1 = 45,
        SCHED_SPECIAL_ATTACK2 = 46,
        SCHED_STANDOFF = 47,
        SCHED_SWITCH_TO_PENDING_WEAPON = 65,
        SCHED_TAKE_COVER_FROM_BEST_SOUND = 28,
        SCHED_TAKE_COVER_FROM_ENEMY = 27,
        SCHED_TAKE_COVER_FROM_ORIGIN = 30,
        SCHED_TARGET_CHASE = 21,
        /// <summary>Face NPC target.</summary>
        SCHED_TARGET_FACE = 20,
        /// <summary>Human victory dance.</summary>
        SCHED_VICTORY_DANCE = 19,
        SCHED_WAIT_FOR_SCRIPT = 55,
        SCHED_WAIT_FOR_SPEAK_FINISH = 67,
        SCHED_WAKE_ANGRY = 4
    }
}