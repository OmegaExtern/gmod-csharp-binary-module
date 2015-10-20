namespace GarrysModLuaShared
{
    class luaL_Reg
    {
        public string name;
        public lua_CFunction func;

        luaL_Reg()
        {}

        public luaL_Reg(string name, lua_CFunction func)
        {
            this.name = name;
            this.func = func;
        }
    }
}