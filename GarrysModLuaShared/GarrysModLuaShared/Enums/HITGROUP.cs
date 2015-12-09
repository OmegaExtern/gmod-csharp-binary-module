namespace GarrysModLuaShared.Enums
{
    public enum HITGROUP
    {
        /// <summary>
        ///     1:1 damage. This hitgroup is not present on default player models.It is unknown how this is generated in
        ///     GM:ScalePlayerDamage, but it occurs when shot by NPCs ( npc_combine_s ) for example.
        /// </summary>
        HITGROUP_GENERIC = 0,

        /// <summary>Head</summary>
        HITGROUP_HEAD = 1,

        /// <summary>Chest</summary>
        HITGROUP_CHEST = 2,

        /// <summary>Stomach</summary>
        HITGROUP_STOMACH = 3,

        /// <summary>Left arm</summary>
        HITGROUP_LEFTARM = 4,

        /// <summary>Right arm</summary>
        HITGROUP_RIGHTARM = 5,

        /// <summary>Left leg</summary>
        HITGROUP_LEFTLEG = 6,

        /// <summary>Right leg</summary>
        HITGROUP_RIGHTLEG = 7,

        /// <summary>Gear. Supposed to be belt area.This hitgroup is not present on default player models.</summary>
        HITGROUP_GEAR = 10
    }
}