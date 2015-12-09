namespace GarrysModLuaShared.Enums
{
    public enum TEAM
    {
        /// <summary>Connecting team ID, set when player connects to the server</summary>
        TEAM_CONNECTING = 0,

        /// <summary>Spectator team ID</summary>
        TEAM_SPECTATOR = 1002,

        /// <summary>Unassigned team ID, set right after player connected</summary>
        TEAM_UNASSIGNED = 1001
    }
}