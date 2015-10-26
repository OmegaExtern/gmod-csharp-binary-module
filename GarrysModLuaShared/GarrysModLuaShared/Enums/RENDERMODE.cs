namespace GarrysModLuaShared.Enums
{
    public enum RENDERMODE
    {
        /// <summary>Normal render mode</summary>
        RENDERMODE_NORMAL = 0,
        RENDERMODE_TRANSCOLOR = 1,
        RENDERMODE_TRANSTEXTURE = 2,
        RENDERMODE_GLOW = 3,
        /// <summary>Use this to make alpha of Color work for your entity. For players, it must be set for their active weapon aswell.</summary>
        RENDERMODE_TRANSALPHA = 4,
        RENDERMODE_TRANSADD = 5,
        RENDERMODE_ENVIROMENTAL = 6,
        RENDERMODE_TRANSADDFRAMEBLEND = 7,
        RENDERMODE_TRANSALPHADD = 8,
        RENDERMODE_WORLDGLOW = 9,
        RENDERMODE_NONE = 10
    }
}