namespace GarrysModLuaShared.Classes
{
    public sealed class Player : Entity
    {
        public Player(int index) : base(index) { }

        public Player(uint id) : base(LuaTable._G.InvokeObject(nameof(Global.Player), id).GetIndex()) { }
    }
}