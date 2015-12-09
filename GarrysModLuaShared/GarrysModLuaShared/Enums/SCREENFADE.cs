namespace GarrysModLuaShared.Enums
{
    public enum SCREENFADE
    {
        /// <summary>Fade out after the hold time has passed</summary>
        SCREENFADE_IN = 1,

        /// <summary>Fade in, hold time passes, disappear</summary>
        SCREENFADE_OUT = 2,

        /// <summary>With white color, turns the screen black</summary>
        SCREENFADE_MODULATE = 4,

        /// <summary>No effects, never disappear</summary>
        SCREENFADE_STAYOUT = 8,

        /// <summary>Appear, Disappear, no effects</summary>
        SCREENFADE_PURGE = 16
    }
}