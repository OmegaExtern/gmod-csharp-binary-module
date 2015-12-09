namespace GarrysModLuaShared.Enums
{
    public enum NPC
    {
        /// <summary>Invalid state</summary>
        NPC_STATE_INVALID = -1,

        /// <summary>NPC default state</summary>
        NPC_STATE_NONE = 0,

        /// <summary>NPC is idle</summary>
        NPC_STATE_IDLE = 1,

        /// <summary>NPC is alert and searching for enemies</summary>
        NPC_STATE_ALERT = 2,

        /// <summary>NPC is in combat</summary>
        NPC_STATE_COMBAT = 3,

        /// <summary>NPC is executing scripted sequence</summary>
        NPC_STATE_SCRIPT = 4,

        /// <summary>NPC is playing dead (used for expressions)</summary>
        NPC_STATE_PLAYDEAD = 5,

        /// <summary>NPC is prone to death</summary>
        NPC_STATE_PRONE = 6,

        /// <summary>NPC is dead</summary>
        NPC_STATE_DEAD = 7
    }
}