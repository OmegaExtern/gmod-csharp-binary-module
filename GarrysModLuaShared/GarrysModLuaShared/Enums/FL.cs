namespace GarrysModLuaShared.Enums
{
    public enum FL : long
    {
        /// <summary>Is the entity on ground or not</summary>
        FL_ONGROUND = 1,

        /// <summary>Is player ducking or not</summary>
        FL_DUCKING = 2,

        /// <summary>Is the player in the process of ducking or standing up</summary>
        FL_ANIMDUCKING = 4,

        /// <summary>The player is jumping out of water</summary>
        FL_WATERJUMP = 8,

        /// <summary>This player is controlling a func_train</summary>
        FL_ONTRAIN = 16,
        FL_INRAIN = 32,

        /// <summary>Completely freezes the player</summary>
        FL_FROZEN = 64,

        /// <summary>
        ///     This player is controlling something UI related in the world, this prevents his movement, but doesn't freeze
        ///     mouse movement, jumping, etc.
        /// </summary>
        FL_ATCONTROLS = 128,

        /// <summary>Is this entity a player or not</summary>
        FL_CLIENT = 256,

        /// <summary>Bots have this flag</summary>
        FL_FAKECLIENT = 512,

        /// <summary>Is the player in water or not</summary>
        FL_INWATER = 1024,

        /// <summary>This entity can fly</summary>
        FL_FLY = 2048,

        /// <summary>This entity can swim</summary>
        FL_SWIM = 4096,

        /// <summary>This entity is a func_conveyor</summary>
        FL_CONVEYOR = 8192,

        /// <summary>NPCs have this flag</summary>
        FL_NPC = 16384,

        /// <summary>Grants godmode to the player</summary>
        FL_GODMODE = 32768,

        /// <summary>Makes the entity invisible to AI</summary>
        FL_NOTARGET = 65536,

        /// <summary>This entity can be aimed at</summary>
        FL_AIMTARGET = 131072,
        FL_PARTIALGROUND = 262144,
        FL_STATICPROP = 524288,
        FL_GRAPHED = 1048576,

        /// <summary>This entity is a grenade, unused</summary>
        FL_GRENADE = 2097152,
        FL_STEPMOVEMENT = 4194304,

        /// <summary>Doesn't generate touch functions, calls ENTITY:EndTouch when this flag gets set during a touch callback</summary>
        FL_DONTTOUCH = 8388608,
        FL_BASEVELOCITY = 16777216,

        /// <summary>This entity is a brush and part of the world</summary>
        FL_WORLDBRUSH = 33554432,

        /// <summary>This entity can be seen by NPCs</summary>
        FL_OBJECT = 67108864,

        /// <summary>This entity is about to get removed</summary>
        FL_KILLME = 134217728,

        /// <summary>This entity is on fire</summary>
        FL_ONFIRE = 268435456,

        /// <summary>The entity is currently dissolving</summary>
        FL_DISSOLVING = 536870912,

        /// <summary>This entity is about to become a ragdoll</summary>
        FL_TRANSRAGDOLL = 1073741824,

        /// <summary>This moving door can't be blocked by the player</summary>
        FL_UNBLOCKABLE_BY_PLAYER = 2147483648
    }
}