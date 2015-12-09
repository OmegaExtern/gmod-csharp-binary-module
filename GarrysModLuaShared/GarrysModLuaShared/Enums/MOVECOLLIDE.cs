namespace GarrysModLuaShared.Enums
{
    public enum MOVECOLLIDE
    {
        /// <summary>Default behaviour</summary>
        MOVECOLLIDE_DEFAULT = 0,

        /// <summary>Entity will bouce</summary>
        MOVECOLLIDE_FLY_BOUNCE = 1,
        MOVECOLLIDE_FLY_CUSTOM = 2,

        /// <summary>Entity will slide</summary>
        MOVECOLLIDE_FLY_SLIDE = 3,
        MOVECOLLIDE_COUNT = 4
    }
}