namespace GarrysModLuaShared.Enums
{
    public enum PATTACH
    {
        /// <summary>Particle spawns in entity</summary>
        PATTACH_ABSORIGIN = 0,

        /// <summary>Particle attaches to entitys origin and follows the entity</summary>
        PATTACH_ABSORIGIN_FOLLOW = 1,
        PATTACH_CUSTOMORIGIN = 2,

        /// <summary>Particle attaches to passed to ParticleEffectAttach attachment id</summary>
        PATTACH_POINT = 3,

        /// <summary>Particle attaches to passed to ParticleEffectAttach attachment id and follows the entity</summary>
        PATTACH_POINT_FOLLOW = 4,

        /// <summary>Particle spawns in the beginning of coordinates, Vector( 0, 0, 0 ).</summary>
        PATTACH_WORLDORIGIN = 5
    }
}