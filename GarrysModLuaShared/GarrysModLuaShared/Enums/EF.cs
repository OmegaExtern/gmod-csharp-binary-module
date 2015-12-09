namespace GarrysModLuaShared.Enums
{
    public enum EF
    {
        /// <summary>Bonemerges the entity to it's parent</summary>
        EF_BONEMERGE = 1,
        EF_BONEMERGE_FASTCULL = 128,
        EF_BRIGHTLIGHT = 2,
        EF_DIMLIGHT = 4,
        EF_NOINTERP = 8,

        /// <summary>Disables shadow</summary>
        EF_NOSHADOW = 16,

        /// <summary>Prevents the entity from drawing and networking.</summary>
        EF_NODRAW = 32,
        EF_NORECEIVESHADOW = 64,

        /// <summary>Makes the entity blink</summary>
        EF_ITEM_BLINK = 256,
        EF_PARENT_ANIMATES = 512
    }
}