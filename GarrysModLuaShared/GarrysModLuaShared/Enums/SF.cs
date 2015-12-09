namespace GarrysModLuaShared.Enums
{
    public enum SF
    {
        /// <summary>Citizen that resupplies ammo</summary>
        SF_CITIZEN_AMMORESUPPLIER = 524288,
        SF_CITIZEN_FOLLOW = 65536,
        SF_CITIZEN_IGNORE_SEMAPHORE = 2097152,

        /// <summary>Makes the citizen a medic</summary>
        SF_CITIZEN_MEDIC = 131072,
        SF_CITIZEN_NOT_COMMANDABLE = 1048576,

        /// <summary>Gives the citizen a random head</summary>
        SF_CITIZEN_RANDOM_HEAD = 262144,

        /// <summary>Gives the citizen a random female head</summary>
        SF_CITIZEN_RANDOM_HEAD_FEMALE = 8388608,

        /// <summary>Gives the citizen a random male head</summary>
        SF_CITIZEN_RANDOM_HEAD_MALE = 4194304,
        SF_CITIZEN_USE_RENDER_BOUNDS = 16777216,

        /// <summary>Makes the floor turret friendly</summary>
        SF_FLOOR_TURRET_CITIZEN = 512,
        SF_NPC_ALTCOLLISION = 4096,
        SF_NPC_ALWAYSTHINK = 1024,

        /// <summary>NPC Drops health kit when it dies</summary>
        SF_NPC_DROP_HEALTHKIT = 8,
        SF_NPC_FADE_CORPSE = 512,
        SF_NPC_FALL_TO_GROUND = 4,
        SF_NPC_GAG = 2,
        SF_NPC_LONG_RANGE = 256,
        SF_NPC_NO_PLAYER_PUSHAWAY = 16384,

        /// <summary>NPC Doesn't drop weapon on death</summary>
        SF_NPC_NO_WEAPON_DROP = 8192,
        SF_NPC_START_EFFICIENT = 16,
        SF_NPC_TEMPLATE = 2048,
        SF_NPC_WAIT_FOR_SCRIPT = 128,
        SF_NPC_WAIT_TILL_SEEN = 1,
        SF_PHYSBOX_MOTIONDISABLED = 32768,
        SF_PHYSBOX_NEVER_PICK_UP = 2097152,
        SF_PHYSPROP_MOTIONDISABLED = 8,

        /// <summary>Prevent that physbox from being picked up</summary>
        SF_PHYSPROP_PREVENT_PICKUP = 512,

        /// <summary>Makes the rollermine friendly</summary>
        SF_ROLLERMINE_FRIENDLY = 65536
    }
}