namespace GarrysModLuaShared.Enums
{
    public enum COLLISION
    {
        /// <summary>Normal</summary>
        COLLISION_GROUP_NONE = 0,
        /// <summary>Collides with nothing but world and static stuff</summary>
        COLLISION_GROUP_DEBRIS = 1,
        /// <summary>Same as debris, but hits triggers. Useful for an item that can be shot, but doesn't collide.</summary>
        COLLISION_GROUP_DEBRIS_TRIGGER = 2,
        /// <summary>Collides with everything except other interactive debris or debris</summary>
        COLLISION_GROUP_INTERACTIVE_DEBRIS = 3,
        /// <summary>Collides with everything except interactive debris or debris</summary>
        COLLISION_GROUP_INTERACTIVE = 4,
        COLLISION_GROUP_PLAYER = 5,
        COLLISION_GROUP_BREAKABLE_GLASS = 6,
        COLLISION_GROUP_VEHICLE = 7,
        /// <summary>For HL2, same as Collision_Group_Player, for TF2, this filters out other players and CBaseObjects</summary>
        COLLISION_GROUP_PLAYER_MOVEMENT = 8,
        COLLISION_GROUP_NPC = 9,
        /// <summary>Doesn't collide with anything, no traces</summary>
        COLLISION_GROUP_IN_VEHICLE = 10,
        /// <summary>Doesn't collide with players</summary>
        COLLISION_GROUP_WEAPON = 11,
        /// <summary>Only collides with vehicles</summary>
        COLLISION_GROUP_VEHICLE_CLIP = 12,
        COLLISION_GROUP_PROJECTILE = 13,
        /// <summary>Blocks entities not permitted to get near moving doors</summary>
        COLLISION_GROUP_DOOR_BLOCKER = 14,
        /// <summary>Let's the Player through, nothing else.</summary>
        COLLISION_GROUP_PASSABLE_DOOR = 15,
        /// <summary>Things that are dissolving are in this group</summary>
        COLLISION_GROUP_DISSOLVING = 16,
        /// <summary>Nonsolid on client and server, pushaway in player code</summary>
        COLLISION_GROUP_PUSHAWAY = 17,
        COLLISION_GROUP_NPC_ACTOR = 18,
        COLLISION_GROUP_NPC_SCRIPTED = 19,
        /// <summary>Doesn't collide with players/props</summary>
        COLLISION_GROUP_WORLD = 20
    }
}