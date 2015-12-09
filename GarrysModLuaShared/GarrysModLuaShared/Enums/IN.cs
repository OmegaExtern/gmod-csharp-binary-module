namespace GarrysModLuaShared.Enums
{
    public enum IN
    {
        /// <summary>+alt1 bound key</summary>
        IN_ALT1 = 16384,

        /// <summary>+alt2 bound key</summary>
        IN_ALT2 = 32768,

        /// <summary>+attack bound key ( Default: Left Mouse Button )</summary>
        IN_ATTACK = 1,

        /// <summary>+attack2 bound key ( Default: Right Mouse Button )</summary>
        IN_ATTACK2 = 2048,

        /// <summary>+back bound key ( Default: S )</summary>
        IN_BACK = 16,

        /// <summary>+duck bound key ( Default: CTRL )</summary>
        IN_DUCK = 4,

        /// <summary>+forward bound key ( Default: W )</summary>
        IN_FORWARD = 8,

        /// <summary>+jump bound key ( Default: Space )</summary>
        IN_JUMP = 2,

        /// <summary>+left bound key ( Look left )</summary>
        IN_LEFT = 128,

        /// <summary>+moveleft bound key ( Default: A )</summary>
        IN_MOVELEFT = 512,

        /// <summary>+moveright bound key ( Default: D )</summary>
        IN_MOVERIGHT = 1024,

        /// <summary>+reload bound key ( Default: R )</summary>
        IN_RELOAD = 8192,

        /// <summary>+right bound key ( Look right )</summary>
        IN_RIGHT = 256,

        /// <summary>+showscores bound key ( Default: Tab )</summary>
        IN_SCORE = 65536,

        /// <summary>+speed bound key ( Default: Shift )</summary>
        IN_SPEED = 131072,

        /// <summary>+use bound key ( Default: E )</summary>
        IN_USE = 32,

        /// <summary>+walk bound key ( Slow walk )</summary>
        IN_WALK = 262144,

        /// <summary>+zoom bound key ( Suit Zoom )</summary>
        IN_ZOOM = 524288,

        /// <summary>+grenade1 bound key</summary>
        IN_GRENADE1 = 8388608,

        /// <summary>+grenade2 bound key</summary>
        IN_GRENADE2 = 16777216,

        /// <summary>For use in weapons. Set in the physgun when scrolling an object away from you.</summary>
        IN_WEAPON1 = 1048576,

        /// <summary>For use in weapons. Set in the physgun when scrolling an object towards you.</summary>
        IN_WEAPON2 = 2097152,
        IN_BULLRUSH = 4194304,
        IN_CANCEL = 64,
        IN_RUN = 4096
    }
}