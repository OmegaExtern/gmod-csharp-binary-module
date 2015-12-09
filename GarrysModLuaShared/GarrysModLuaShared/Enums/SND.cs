namespace GarrysModLuaShared.Enums
{
    public enum SND
    {
        /// <summary>To keep the compiler happy</summary>
        SND_NOFLAGS = 0,

        /// <summary>Change sound vol</summary>
        SND_CHANGE_VOL = 1,

        /// <summary>Change sound pitch</summary>
        SND_CHANGE_PITCH = 2,

        /// <summary>Stop the sound</summary>
        SND_STOP = 4,

        /// <summary>We're spawning, used in some cases for ambients. Not sent over net, only a param between dll and server.</summary>
        SND_SPAWNING = 8,

        /// <summary>Sound has an initial delay</summary>
        SND_DELAY = 16,

        /// <summary>Stop all looping sounds on the entity.</summary>
        SND_STOP_LOOPING = 32,

        /// <summary>This sound should be paused if the game is paused</summary>
        SND_SHOULDPAUSE = 128,
        SND_IGNORE_PHONEMES = 256,

        /// <summary>Used to change all sounds emitted by an entity, regardless of scriptname</summary>
        SND_IGNORE_NAME = 512,
        SND_DO_NOT_OVERWRITE_EXISTING_ON_CHANNEL = 1024
    }
}