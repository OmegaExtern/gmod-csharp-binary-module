namespace GarrysModLuaShared.Enums
{
    public enum OBS_MODE
    {
        /// <summary>Not spectating</summary>
        OBS_MODE_NONE = 0,
        OBS_MODE_DEATHCAM = 1,

        /// <summary>TF2-like freezecam</summary>
        OBS_MODE_FREEZECAM = 2,

        /// <summary>Same as OBS_MODE_CHASE, but you can't rotate the view</summary>
        OBS_MODE_FIXED = 3,

        /// <summary>First person cam</summary>
        OBS_MODE_IN_EYE = 4,

        /// <summary>Chase cam, 3rd person cam, free rotation around the spectated target</summary>
        OBS_MODE_CHASE = 5,

        /// <summary>Free roam/noclip-alike</summary>
        OBS_MODE_ROAMING = 6
    }
}