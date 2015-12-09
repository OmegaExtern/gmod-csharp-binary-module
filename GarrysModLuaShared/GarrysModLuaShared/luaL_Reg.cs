namespace GarrysModLuaShared
{
    class luaL_Reg
    {
        public lua_CFunction func;
        public string name;

        luaL_Reg() { }

        public luaL_Reg(string name, lua_CFunction func)
        {
            this.name = name;
            this.func = func;
        }
    }
}