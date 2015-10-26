namespace GarrysModLuaShared.Enums
{
    public enum TRANSMIT
    {
        /// <summary>Never transmit the entity, default for point entities</summary>
        TRANSMIT_NEVER = 1,
        /// <summary>Transmit when entity is in players view</summary>
        TRANSMIT_PVS = 2,
        /// <summary>Always transmit the entity</summary>
        TRANSMIT_ALWAYS = 3
    }
}