namespace GarrysModLuaShared.Enums
{
    public enum MOVETYPE
    {
        /// <summary>Don't move</summary>
        MOVETYPE_NONE = 0,
        /// <summary>For players, in TF2 commander view, etc</summary>
        MOVETYPE_ISOMETRIC = 1,
        /// <summary>Player only, moving on the ground</summary>
        MOVETYPE_WALK = 2,
        /// <summary>Monster/NPC movement</summary>
        MOVETYPE_STEP = 3,
        /// <summary>Fly, no gravity</summary>
        MOVETYPE_FLY = 4,
        /// <summary>Fly, with gravity</summary>
        MOVETYPE_FLYGRAVITY = 5,
        /// <summary>Physics movetype</summary>
        MOVETYPE_VPHYSICS = 6,
        /// <summary>No clip to world, but pushes and crushes things</summary>
        MOVETYPE_PUSH = 7,
        /// <summary>Noclip</summary>
        MOVETYPE_NOCLIP = 8,
        /// <summary>For players, when moving on a ladder</summary>
        MOVETYPE_LADDER = 9,
        /// <summary>Spectator movetype. DO NOT use this to make player spectate</summary>
        MOVETYPE_OBSERVER = 10,
        /// <summary>Custom movetype, can be applied to the player to prevent the default movement code from running, while still calling the related hooks</summary>
        MOVETYPE_CUSTOM = 11
    }
}