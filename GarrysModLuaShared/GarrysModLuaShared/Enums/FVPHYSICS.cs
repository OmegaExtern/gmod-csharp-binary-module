namespace GarrysModLuaShared.Enums
{
    public enum FVPHYSICS
    {
        /// <summary>Won't receive physics forces from collisions and won't collide with other PhysObj with the same flag set</summary>
        FVPHYSICS_CONSTRAINT_STATIC = 2,

        /// <summary>
        ///     Colliding with entities will cause 1000 damage with DMG_DISSOLVE as the damage type, but only if
        ///     EFL_NO_DISSOLVE is not set
        /// </summary>
        FVPHYSICS_DMG_DISSOLVE = 512,
        FVPHYSICS_DMG_SLICE = 1,

        /// <summary>Will deal high physics damage(?) even with a small mass</summary>
        FVPHYSICS_HEAVY_OBJECT = 32,

        /// <summary>
        ///     This PhysObj is part of an entity with multiple PhysObj , such as a ragdoll or a vehicle , and will be
        ///     considered during collision damage events
        /// </summary>
        FVPHYSICS_MULTIOBJECT_ENTITY = 16,

        /// <summary>Colliding with entities won't cause physics damage</summary>
        FVPHYSICS_NO_IMPACT_DMG = 1024,

        /// <summary>
        ///     Like FVPHYSICS_NO_NPC_IMPACT_DMG, but only checks for NPCs. Usually set on Combine Balls fired by Combine
        ///     Soldiers
        /// </summary>
        FVPHYSICS_NO_NPC_IMPACT_DMG = 2048,

        /// <summary>Doesn't allow the player to pick this PhysObj with the Gravity Gun or +use pickup</summary>
        FVPHYSICS_NO_PLAYER_PICKUP = 128,

        /// <summary>
        ///     We won't collide with other PhysObj associated to the same entity, only used for vehicles and ragdolls held by
        ///     the Super Gravity Gun
        /// </summary>
        FVPHYSICS_NO_SELF_COLLISIONS = 32768,

        /// <summary>This PhysObj is part of a ragdoll</summary>
        FVPHYSICS_PART_OF_RAGDOLL = 8,

        /// <summary>Set by the physics engine when two PhysObj are penetrating each other</summary>
        FVPHYSICS_PENETRATING = 64,

        /// <summary>Set when the player is holding this PhysObj with the Gravity Gun or +use pickup</summary>
        FVPHYSICS_PLAYER_HELD = 4,

        /// <summary>This object was thrown by the Gravity Gun , stuns Antlion guards, Hunters, and squashes Antlion grubs</summary>
        FVPHYSICS_WAS_THROWN = 256
    }
}