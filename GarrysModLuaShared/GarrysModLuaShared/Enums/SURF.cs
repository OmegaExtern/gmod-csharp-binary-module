namespace GarrysModLuaShared.Enums
{
    public enum SURF
    {
        SURF_BUMPLIGHT = 2048,
        SURF_HINT = 256,
        /// <summary>This surface is part of an entity's hitbox</summary>
        SURF_HITBOX = 32768,
        SURF_LIGHT = 1,
        SURF_NOCHOP = 16384,
        /// <summary>No decals are applied to this surface</summary>
        SURF_NODECALS = 8192,
        /// <summary>This surface is an invisible entity, equivalent to HitNoDraw in TraceResult structure</summary>
        SURF_NODRAW = 128,
        /// <summary>This surface has no lights calculated</summary>
        SURF_NOLIGHT = 1024,
        /// <summary>This surface cannot have portals placed on, used by Portal's gun</summary>
        SURF_NOPORTAL = 32,
        /// <summary>No shadows are cast on this surface</summary>
        SURF_NOSHADOWS = 4096,
        /// <summary>This surface can be ignored by impact effects</summary>
        SURF_SKIP = 512,
        /// <summary>This surface is a skybox, equivalent to HitSky in TraceResult structure</summary>
        SURF_SKY = 4,
        /// <summary>This surface is translucent</summary>
        SURF_TRANS = 16,
        /// <summary>This surface is a trigger, seems unused</summary>
        SURF_TRIGGER = 64,
        /// <summary>This surface is animated water</summary>
        SURF_WARP = 8
    }
}