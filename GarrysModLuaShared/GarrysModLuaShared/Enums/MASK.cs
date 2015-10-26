namespace GarrysModLuaShared.Enums
{
    public enum MASK : long
    {
        /// <summary>Anything that is not empty space</summary>
        MASK_ALL = 4294967295,
        /// <summary>Anything that blocks line of sight for AI</summary>
        MASK_BLOCKLOS = 16449,
        /// <summary>Anything that blocks line of sight for AI or NPCs</summary>
        MASK_BLOCKLOS_AND_NPCS = 33570881,
        /// <summary>Water that is moving (may not work)</summary>
        MASK_CURRENT = 16515072,
        /// <summary>Anything that blocks corpse movement</summary>
        MASK_DEADSOLID = 65547,
        /// <summary>Anything that blocks NPC movement</summary>
        MASK_NPCSOLID = 33701899,
        /// <summary>Anything that blocks NPC movement, except other NPCs</summary>
        MASK_NPCSOLID_BRUSHONLY = 147467,
        /// <summary>The world entity</summary>
        MASK_NPCWORLDSTATIC = 131083,
        /// <summary>Anything that blocks lighting</summary>
        MASK_OPAQUE = 16513,
        /// <summary>Anything that blocks lighting, including NPCs</summary>
        MASK_OPAQUE_AND_NPCS = 33570945,
        /// <summary>Anything that blocks player movement</summary>
        MASK_PLAYERSOLID = 33636363,
        /// <summary>World + Brushes + Player Clips</summary>
        MASK_PLAYERSOLID_BRUSHONLY = 81931,
        /// <summary>Anything that stops a bullet (including hitboxes)</summary>
        MASK_SHOT = 1174421507,
        /// <summary>Anything that stops a bullet (excluding hitboxes)</summary>
        MASK_SHOT_HULL = 100679691,
        /// <summary>Solids except for grates</summary>
        MASK_SHOT_PORTAL = 33570819,
        /// <summary>Anything that is (normally) solid</summary>
        MASK_SOLID = 33570827,
        /// <summary>World + Brushes</summary>
        MASK_SOLID_BRUSHONLY = 16395,
        /// <summary>Things that split area portals</summary>
        MASK_SPLITAREAPORTAL = 48,
        /// <summary>Anything that blocks line of sight for players</summary>
        MASK_VISIBLE = 24705,
        /// <summary>Anything that blocks line of sight for players, including NPCs</summary>
        MASK_VISIBLE_AND_NPCS = 33579137,
        /// <summary>Anything that has water-like physics</summary>
        MASK_WATER = 16432
    }
}