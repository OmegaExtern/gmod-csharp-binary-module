namespace GarrysModLuaShared.Enums
{
    public enum TRACER
    {
        /// <summary>Generates no tracer effects</summary>
        TRACER_NONE = 0,

        /// <summary>Generates tracer effects</summary>
        TRACER_LINE = 1,
        TRACER_RAIL = 2,
        TRACER_BEAM = 3,

        /// <summary>Generates tracer and makes whizzing noises if the bullet flies past the player being shot at</summary>
        TRACER_LINE_AND_WHIZ = 4
    }
}