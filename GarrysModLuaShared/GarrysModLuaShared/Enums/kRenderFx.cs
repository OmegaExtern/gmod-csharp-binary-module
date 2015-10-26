namespace GarrysModLuaShared.Enums
{
    public enum kRenderFx
    {
        /// <summary>None. No change.</summary>
        kRenderFxNone = 0,
        /// <summary>Slowly pulses the entitys transparency, +-15 to the current alpha.</summary>
        kRenderFxPulseSlow = 1,
        /// <summary>Quickly pulses the entitys transparency, +-15 to the current alpha.</summary>
        kRenderFxPulseFast = 2,
        /// <summary>Slowly pulses the entitys transparency, +-60 to the current alpha.</summary>
        kRenderFxPulseSlowWide = 3,
        /// <summary>Quickly pulses the entitys transparency, +-60 to the current alpha.</summary>
        kRenderFxPulseFastWide = 4,
        /// <summary>Slowly fades away the entity, making it completely invisible.Starts from whatever alpha the entity currently has set.</summary>
        kRenderFxFadeSlow = 5,
        /// <summary>Quickly fades away the entity, making it completely invisible.Starts from whatever alpha the entity currently has set.</summary>
        kRenderFxFadeFast = 6,
        /// <summary>Slowly solidifies the entity, making it fully opaque.Starts from whatever alpha the entity currently has set.</summary>
        kRenderFxSolidSlow = 7,
        /// <summary>Quickly solidifies the entity, making it fully opaque.Starts from whatever alpha the entity currently has set.</summary>
        kRenderFxSolidFast = 8,
        /// <summary>Slowly switches the entitys transparency between its alpha and 0.</summary>
        kRenderFxStrobeSlow = 9,
        /// <summary>Quickly switches the entitys transparency between its alpha and 0.</summary>
        kRenderFxStrobeFast = 10,
        /// <summary>Very quickly switches the entitys transparency between its alpha and 0.</summary>
        kRenderFxStrobeFaster = 11,
        /// <summary>Same as Strobe Slow, but the interval is more randomized.</summary>
        kRenderFxFlickerSlow = 12,
        /// <summary>Same as Strobe Fast, but the interval is more randomized.</summary>
        kRenderFxFlickerFast = 13,
        kRenderFxNoDissipation = 14,
        /// <summary>Flickers ( randomizes ) the entitys transparency</summary>
        kRenderFxDistort = 15,
        /// <summary>Same as Distort, but fades the entity away the farther you are from it.</summary>
        kRenderFxHologram = 16,
        kRenderFxExplode = 17,
        kRenderFxGlowShell = 18,
        kRenderFxClampMinScale = 19,
        kRenderFxEnvRain = 20,
        kRenderFxEnvSnow = 21,
        kRenderFxSpotlight = 22,
        kRenderFxRagdoll = 23,
        /// <summary>Quickly pulses the entitys transparency, from 0 to 255.</summary>
        kRenderFxPulseFastWider = 24
    }
}