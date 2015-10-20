using System;

namespace GarrysModLuaShared
{
    unsafe struct luaL_Buffer
    {
        /// <summary>Current position in buffer</summary>
        public int p;
        /// <summary>Number of strings in the stack (level)</summary>
        public int lvl;
        public IntPtr luaState;
        public fixed char buffer[LuaConfig.LUAL_BUFFERSIZE];
    }
}