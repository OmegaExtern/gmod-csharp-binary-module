namespace GarrysModLuaShared.Enums
{
    public enum SOLID
    {
        /// <summary>Does not collide with anything</summary>
        SOLID_NONE = 0,
        SOLID_BSP = 1,

        /// <summary>Uses the entity's axis-aligned bounding box for collisions</summary>
        SOLID_BBOX = 2,

        /// <summary>Uses the entity's object-aligned bounding box for collisions</summary>
        SOLID_OBB = 3,

        /// <summary>Same as SOLID_OBB but restricts orientation to the Z-axisNote: Seems to be broken.</summary>
        SOLID_OBB_YAW = 4,
        SOLID_CUSTOM = 5,

        /// <summary>Uses the collision mesh of the entities model</summary>
        SOLID_VPHYSICS = 6
    }
}