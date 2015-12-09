namespace GarrysModLuaShared.Enums
{
    public enum USE
    {
        USE_OFF = 0,
        USE_ON = 1,
        USE_SET = 2,
        USE_TOGGLE = 3,

        /// <summary>Fire as long as player holds their use key.</summary>
        CONTINUOUS_USE = 0,

        /// <summary>Toggling true/false use.</summary>
        ONOFF_USE = 1,

        /// <summary>Like a wheel turning.</summary>
        DIRECTIONAL_USE = 2,

        /// <summary>Fire only once when player presses their use key.</summary>
        SIMPLE_USE = 3
    }
}