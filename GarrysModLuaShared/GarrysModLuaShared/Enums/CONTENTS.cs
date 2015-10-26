namespace GarrysModLuaShared.Enums
{
    public enum CONTENTS
    {
        /// <summary>Things that are not solid</summary>
        CONTENTS_EMPTY = 0,
        /// <summary>Things that are solid</summary>
        CONTENTS_SOLID = 1,
        /// <summary>Glass</summary>
        CONTENTS_WINDOW = 2,
        CONTENTS_AUX = 4,
        /// <summary>Bullets go through, solids don't</summary>
        CONTENTS_GRATE = 8,
        CONTENTS_SLIME = 16,
        /// <summary>Hits world but not skybox</summary>
        CONTENTS_WATER = 32,
        /// <summary>Things that block line of sight</summary>
        CONTENTS_BLOCKLOS = 64,
        /// <summary>Things that block light</summary>
        CONTENTS_OPAQUE = 128,
        CONTENTS_TESTFOGVOLUME = 256,
        CONTENTS_TEAM4 = 512,
        CONTENTS_TEAM3 = 1024,
        CONTENTS_TEAM1 = 2048,
        CONTENTS_TEAM2 = 4096,
        CONTENTS_IGNORE_NODRAW_OPAQUE = 8192,
        CONTENTS_MOVEABLE = 16384,
        CONTENTS_AREAPORTAL = 32768,
        CONTENTS_PLAYERCLIP = 65536,
        CONTENTS_MONSTERCLIP = 131072,
        CONTENTS_CURRENT_0 = 262144,
        CONTENTS_CURRENT_180 = 1048576,
        CONTENTS_CURRENT_270 = 2097152,
        CONTENTS_CURRENT_90 = 524288,
        CONTENTS_CURRENT_DOWN = 8388608,
        CONTENTS_CURRENT_UP = 4194304,
        CONTENTS_DEBRIS = 67108864,
        CONTENTS_DETAIL = 134217728,
        /// <summary>Hitbox</summary>
        CONTENTS_HITBOX = 1073741824,
        /// <summary>Ladder</summary>
        CONTENTS_LADDER = 536870912,
        /// <summary>NPCs</summary>
        CONTENTS_MONSTER = 33554432,
        CONTENTS_ORIGIN = 16777216,
        /// <summary>Hits world but not skybox</summary>
        CONTENTS_TRANSLUCENT = 268435456,
        LAST_VISIBLE_CONTENTS = 128,
        ALL_VISIBLE_CONTENTS = 255
    }
}