namespace GarrysModLuaShared.Enums
{
    public enum CHAN
    {
        /// <summary>Used when playing sounds through console commands.</summary>
        CHAN_REPLACE = -1,

        /// <summary>Automatic channel</summary>
        CHAN_AUTO = 0,

        /// <summary>Channel for weapon sounds</summary>
        CHAN_WEAPON = 1,

        /// <summary>Channel for NPC voices</summary>
        CHAN_VOICE = 2,

        /// <summary>Channel for items ( Health kits, etc )</summary>
        CHAN_ITEM = 3,

        /// <summary>Clothing, ragdoll impacts, footsteps, knocking/pounding/punching etc.</summary>
        CHAN_BODY = 4,

        /// <summary>Stream channel from the static or dynamic area</summary>
        CHAN_STREAM = 5,

        /// <summary>A constant/background sound that doesn't require any reaction.</summary>
        CHAN_STATIC = 6,

        /// <summary>TF2s Announcer dialogue channel</summary>
        CHAN_VOICE2 = 7,

        /// <summary>Channel for network voice data</summary>
        CHAN_VOICE_BASE = 8,
        CHAN_USER_BASE = 136
    }
}