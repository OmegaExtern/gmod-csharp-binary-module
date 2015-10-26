namespace GarrysModLuaShared.Enums
{
    public enum EFL
    {
        /// <summary>This is set on bots that are frozen</summary>
        EFL_BOT_FROZEN = 256,
        EFL_CHECK_UNTOUCH = 16777216,
        /// <summary>Some dirty bits with respect to abs computations</summary>
        EFL_DIRTY_ABSANGVELOCITY = 8192,
        EFL_DIRTY_ABSTRANSFORM = 2048,
        EFL_DIRTY_ABSVELOCITY = 4096,
        /// <summary>(Client only) need shadow manager to update the shadow</summary>
        EFL_DIRTY_SHADOWUPDATE = 32,
        EFL_DIRTY_SPATIAL_PARTITION = 32768,
        EFL_DIRTY_SURROUNDING_COLLISION_BOUNDS = 16384,
        /// <summary>Entity shouldn't block NPC line-of-sight</summary>
        EFL_DONTBLOCKLOS = 33554432,
        /// <summary>NPCs should not walk on this entity</summary>
        EFL_DONTWALKON = 67108864,
        /// <summary>Entity is dormant, no updates to client</summary>
        EFL_DORMANT = 2,
        /// <summary>The default behavior in ShouldTransmit is to not send an entity if it doesn't have a model. Certain entities want to be sent anyway because all the drawing logic is in the client DLL. They can set this flag and the engine will transmit them even if they don't have model</summary>
        EFL_FORCE_CHECK_TRANSMIT = 128,
        /// <summary>One of the child entities is a player</summary>
        EFL_HAS_PLAYER_CHILD = 16,
        /// <summary>This is set if the entity detects that it's in the skybox. This forces it to pass the "in PVS" for transmission</summary>
        EFL_IN_SKYBOX = 131072,
        EFL_IS_BEING_LIFTED_BY_BARNACLE = 1048576,
        /// <summary>This is a special entity that should not be deleted when we restart entities only</summary>
        EFL_KEEP_ON_RECREATE_ENTITIES = 16,
        /// <summary>This entity is marked for death -- This allows the game to actually delete ents at a safe time</summary>
        EFL_KILLME = 1,
        /// <summary>Lets us know when the noclip command is active</summary>
        EFL_NOCLIP_ACTIVE = 4,
        /// <summary>Another entity is watching events on this entity (used by teleport)</summary>
        EFL_NOTIFY = 64,
        /// <summary>Don't attach the edict</summary>
        EFL_NO_AUTO_EDICT_ATTACH = 1024,
        /// <summary>Doesn't accept forces from physics damage</summary>
        EFL_NO_DAMAGE_FORCES = -2147483648,
        /// <summary>Entitiy shouldn't dissolve</summary>
        EFL_NO_DISSOLVE = 134217728,
        EFL_NO_GAME_PHYSICS_SIMULATION = 8388608,
        /// <summary>Mega physcannon can't ragdoll these guys</summary>
        EFL_NO_MEGAPHYSCANNON_RAGDOLL = 268435456,
        /// <summary>Physcannon can't pick these up or punt them</summary>
        EFL_NO_PHYSCANNON_INTERACTION = 1073741824,
        EFL_NO_ROTORWASH_PUSH = 2097152,
        EFL_NO_THINK_FUNCTION = 4194304,
        /// <summary>Don't adjust this entity's velocity when transitioning into water</summary>
        EFL_NO_WATER_VELOCITY_CHANGE = 536870912,
        /// <summary>Non-networked entity</summary>
        EFL_SERVER_ONLY = 512,
        /// <summary>Set while a model is setting up its bones</summary>
        EFL_SETTING_UP_BONES = 8,
        /// <summary>Used to determine if an entity is floating</summary>
        EFL_TOUCHING_FLUID = 524288,
        /// <summary>Entities with this flag set show up in the partition even when not solid</summary>
        EFL_USE_PARTITION_WHEN_NOT_SOLID = 262144
    }
}