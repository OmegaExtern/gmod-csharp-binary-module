using System;

namespace GarrysModLuaShared
{
    public struct LuaState : IEquatable<LuaState>
    {
        readonly IntPtr _state;

        LuaState(IntPtr ptr) : this() { _state = ptr; }

        public static implicit operator IntPtr(LuaState luaState) => luaState._state;

        public static implicit operator LuaState(IntPtr ptr) => new LuaState(ptr);

        public static implicit operator LuaState(int value) => new IntPtr(value);

        public static implicit operator LuaState(long value) => new IntPtr(value);

        public static unsafe implicit operator LuaState(void* value) => new IntPtr(value);

        public static implicit operator int(LuaState luaState) => luaState._state.ToInt32();

        public static implicit operator long(LuaState luaState) => luaState._state.ToInt64();

        public static unsafe implicit operator void*(LuaState luaState) => luaState._state.ToPointer();

        public static bool operator ==(LuaState a, LuaState b) => Math.Abs(a._state.ToInt64() - b._state.ToInt64()) == default(long);

        public static bool operator ==(LuaState a, long b) => Math.Abs(a._state.ToInt64() - b) == default(long);

        public static bool operator ==(long b, LuaState a) => Math.Abs(b - a._state.ToInt64()) == default(long);

        public static bool operator ==(LuaState a, int b) => Math.Abs(a._state.ToInt32() - b) == default(int);

        public static bool operator ==(int b, LuaState a) => Math.Abs(b - a._state.ToInt32()) == default(int);

        public static bool operator ==(LuaState a, IntPtr b) => Math.Abs(a._state.ToInt64() - b.ToInt64()) == default(long);

        public static bool operator ==(IntPtr a, LuaState b) => Math.Abs(a.ToInt64() - b._state.ToInt64()) == default(long);

        public static bool operator !=(LuaState a, LuaState b) => !(a == b);

        public static bool operator !=(LuaState a, long b) => !(a == b);

        public static bool operator !=(long b, LuaState a) => !(b == a);

        public static bool operator !=(LuaState a, int b) => !(a == b);

        public static bool operator !=(int b, LuaState a) => !(b == a);

        public static bool operator !=(LuaState a, IntPtr b) => !(a == b);

        public static bool operator !=(IntPtr b, LuaState a) => !(b == a);

        public bool Equals(LuaState other) => _state.Equals(other._state);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is LuaState && Equals((LuaState)obj);
        }

        public override int GetHashCode() => _state.GetHashCode();
    }
}