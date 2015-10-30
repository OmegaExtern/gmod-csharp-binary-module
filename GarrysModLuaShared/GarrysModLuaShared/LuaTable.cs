namespace GarrysModLuaShared
{
    public sealed class LuaTable : LuaObject
    {
        public static readonly LuaTable _G = new LuaTable((int)TableIndex.SpecialGlob);

        public LuaTable(int index) : base(index)
        {}
    }
}