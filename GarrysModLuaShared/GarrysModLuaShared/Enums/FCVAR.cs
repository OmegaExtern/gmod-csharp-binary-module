namespace GarrysModLuaShared.Enums
{
    public enum FCVAR
    {
        /// <summary>Save the ConVar value into config.cfg</summary>
        FCVAR_ARCHIVE = 128,
        /// <summary>Save the ConVar value into config.cfg on XBox</summary>
        FCVAR_ARCHIVE_XBOX = 16777216,
        /// <summary>Requires sv_cheats to be enabled to change/run the command</summary>
        FCVAR_CHEAT = 16384,
        /// <summary>IVEngineClient::ClientCmd is allowed to execute this command</summary>
        FCVAR_CLIENTCMD_CAN_EXECUTE = 1073741824,
        /// <summary>ConVar is defined by the client DLL.This flag is set automatically</summary>
        FCVAR_CLIENTDLL = 8,
        /// <summary>Force the ConVar to be recorded by demo recordings.</summary>
        FCVAR_DEMO = 65536,
        /// <summary>Opposite of FCVAR_DEMO, ensures the ConVar is not recorded in demos</summary>
        FCVAR_DONTRECORD = 131072,
        /// <summary>ConVar is defined by the game DLL.This flag is set automatically</summary>
        FCVAR_GAMEDLL = 4,
        /// <summary>Tells the engine to never print this variable as a string since it contains control sequences</summary>
        FCVAR_NEVER_AS_STRING = 4096,
        /// <summary>No flags</summary>
        FCVAR_NONE = 0,
        /// <summary>For serverside ConVars, notifies all players with blue chat text when the value gets changed</summary>
        FCVAR_NOTIFY = 256,
        /// <summary>Makes the ConVar not changeable while connected to a server or in singleplayer</summary>
        FCVAR_NOT_CONNECTED = 4194304,
        /// <summary>Forces the ConVar to only have printable characters ( No control characters )</summary>
        FCVAR_PRINTABLEONLY = 1024,
        /// <summary>Makes the ConVar value hidden from all clients ( For example sv_password )</summary>
        FCVAR_PROTECTED = 32,
        /// <summary>For serverside ConVars, it will send its value to all clients</summary>
        FCVAR_REPLICATED = 8192,
        /// <summary>Prevents the server from querying value of this ConVar</summary>
        FCVAR_SERVER_CANNOT_QUERY = 536870912,
        /// <summary>Makes the command or ConVar only executeable/changeable from the server console</summary>
        FCVAR_SERVER_CAN_EXECUTE = 268435456,
        /// <summary>Executing the command or changing the ConVar is only allowed in singleplayer</summary>
        FCVAR_SPONLY = 64,
        /// <summary>Don't log the ConVar changes to console/log files/users</summary>
        FCVAR_UNLOGGED = 2048,
        /// <summary>If this is set, don't add to linked list, etc</summary>
        FCVAR_UNREGISTERED = 1,
        /// <summary>For clientside commands, sends the value to the server</summary>
        FCVAR_USERINFO = 512
    }
}