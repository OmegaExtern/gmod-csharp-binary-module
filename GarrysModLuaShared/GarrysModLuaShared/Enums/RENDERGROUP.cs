namespace GarrysModLuaShared.Enums
{
    public enum RENDERGROUP
    {
        /// <summary>For both translucent/transparent and opaque/solid entities</summary>
        RENDERGROUP_BOTH = 9,
        /// <summary>For non transparent/solid entities</summary>
        RENDERGROUP_OPAQUE = 7,
        RENDERGROUP_OPAQUE_BRUSH = 12,
        RENDERGROUP_OPAQUE_HUGE = 1,
        RENDERGROUP_OTHER = 13,
        RENDERGROUP_STATIC = 6,
        RENDERGROUP_STATIC_HUGE = 0,
        /// <summary>For translucent/transparent entities.</summary>
        RENDERGROUP_TRANSLUCENT = 8,
        RENDERGROUP_VIEWMODEL = 10,
        RENDERGROUP_VIEWMODEL_TRANSLUCENT = 11
    }
}