namespace GarrysModLuaShared
{
    public unsafe struct lua_Debug
    {
        public int @event;
        public string name;
        public string namewhat;
        public string what;
        public string source;
        public int currentline;
        public int linedefined;
        public int lastlinedefined;
        public byte nups;
        public byte nparams;
        public char isvararg;
        public char istailcall;
        public fixed char short_src[LuaConfig.LUA_IDSIZE];
    }
}