namespace GarrysModLuaShared.Enums
{
    public enum BONE
    {
        BONE_PHYSICALLY_SIMULATED = 1,
        BONE_PHYSICS_PROCEDURAL = 2,
        BONE_ALWAYS_PROCEDURAL = 4,
        BONE_SCREEN_ALIGN_SPHERE = 8,
        BONE_SCREEN_ALIGN_CYLINDER = 16,
        BONE_CALCULATE_MASK = 31,
        /// <summary>A hitbox is attached to this bone</summary>
        BONE_USED_BY_HITBOX = 256,
        /// <summary>An attachment is attached to this bone</summary>
        BONE_USED_BY_ATTACHMENT = 512,
        BONE_USED_BY_VERTEX_LOD0 = 1024,
        BONE_USED_BY_VERTEX_LOD1 = 2048,
        BONE_USED_BY_VERTEX_LOD2 = 4096,
        BONE_USED_BY_VERTEX_LOD3 = 8192,
        BONE_USED_BY_VERTEX_LOD4 = 16384,
        BONE_USED_BY_VERTEX_LOD5 = 32768,
        BONE_USED_BY_VERTEX_LOD6 = 65536,
        BONE_USED_BY_VERTEX_LOD7 = 131072,
        BONE_USED_BY_VERTEX_MASK = 261120,
        BONE_USED_BY_BONE_MERGE = 262144,
        /// <summary>Is this bone used by anything?( If any BONE_USED_BY_* flags are true )</summary>
        BONE_USED_BY_ANYTHING = 524032,
        BONE_USED_MASK = 524032
    }
}