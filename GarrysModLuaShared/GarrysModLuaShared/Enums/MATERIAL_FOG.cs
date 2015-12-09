namespace GarrysModLuaShared.Enums
{
    public enum MATERIAL_FOG
    {
        /// <summary>No fog</summary>
        MATERIAL_FOG_NONE = 0,

        /// <summary>Linear fog</summary>
        MATERIAL_FOG_LINEAR = 1,

        /// <summary>
        ///     For use in conjunction with render.SetFogZ. Does not work if start distance is bigger than end distance.
        ///     Ignores density setting. Seems to be broken? Used for underwater fog by the engine.
        /// </summary>
        MATERIAL_FOG_LINEAR_BELOW_FOG_Z = 2
    }
}