namespace GarrysModLuaShared.Enums
{
    public enum STENCIL
    {
        /// <summary>Never passes.</summary>
        STENCIL_NEVER = 1,
        /// <summary>Passes when the existing value in the stencil buffer is lower than the reference value.</summary>
        STENCIL_LESS = 2,
        /// <summary>Passes when the existing value in the stencil buffer is equal to the reference value.</summary>
        STENCIL_EQUAL = 3,
        /// <summary>Passes when the existing value in the stencil buffer is lower or equal than the reference value.</summary>
        STENCIL_LESSEQUAL = 4,
        /// <summary>Passes when the existing value in the stencil buffer is higher than the reference value.</summary>
        STENCIL_GREATER = 5,
        /// <summary>Passes when the existing value in the stencil buffer is not equal to the reference value.</summary>
        STENCIL_NOTEQUAL = 6,
        /// <summary>Passes when the existing value in the stencil buffer is higher or equal to the reference value.</summary>
        STENCIL_GREATEREQUAL = 7,
        /// <summary>Always passes.</summary>
        STENCIL_ALWAYS = 8,
        /// <summary>Preserves the existing stencil buffer value.</summary>
        STENCIL_KEEP = 1,
        /// <summary>Sets the value in the stencil buffer to 0.</summary>
        STENCIL_ZERO = 2,
        /// <summary>Sets the value in the stencil buffer to the reference value, set using render.SetStencilReferenceValue.</summary>
        STENCIL_REPLACE = 3,
        /// <summary>Increments the value in the stencil buffer by 1, clamping the result.</summary>
        STENCIL_INCRSAT = 4,
        /// <summary>Decrements the value in the stencil buffer by 1, clamping the result.</summary>
        STENCIL_DECRSAT = 5,
        /// <summary>Inverts the value in the stencil buffer.</summary>
        STENCIL_INVERT = 6,
        /// <summary>Increments the value in the stencil buffer by 1, wrapping around on overflow.</summary>
        STENCIL_INCR = 7,
        /// <summary>Decrements the value in the stencil buffer by 1, wrapping around on overflow.</summary>
        STENCIL_DECR = 8
    }
}