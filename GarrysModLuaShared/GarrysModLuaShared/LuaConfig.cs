namespace GarrysModLuaShared
{
    static class LuaConfig
    {
#if LUA_FLOAT_LONGDOUBLE
        public const int LUAL_BUFFERSIZE = 8192;
#else
        public const int LUAL_BUFFERSIZE = 2048; // 0x80 * sizeof(void*) * sizeof(lua_Integer);
#endif
        public const int LUA_IDSIZE = 60;
    }
}