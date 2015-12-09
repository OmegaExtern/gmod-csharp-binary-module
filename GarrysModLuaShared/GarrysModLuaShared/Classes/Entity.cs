namespace GarrysModLuaShared.Classes
{
    public class Entity : LuaObject
    {
        public Entity(int index) : base(index) { }

        public Entity(uint entityId) : base(LuaTable._G.InvokeObject(nameof(Global.Entity), entityId).GetIndex()) { }

        public Angle EyeAngles() => new Angle(CallObject(nameof(EyeAngles)).GetIndex());

        public Vector GetAbsVelocity() => new Vector(CallObject(nameof(GetAbsVelocity)).GetIndex());

        public Angle GetAngles() => new Angle(CallObject(nameof(GetAngles)).GetIndex());

        public string GetClass() => CallString(nameof(GetClass));
    }
}