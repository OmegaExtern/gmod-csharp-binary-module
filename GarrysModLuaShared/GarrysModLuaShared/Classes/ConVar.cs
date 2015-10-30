using System;

namespace GarrysModLuaShared.Classes
{
    /// <summary>An object returned by <see cref="Global.GetConVar"/> function. It represents a console variable. See <see cref="http://wiki.garrysmod.com/page/ConVars">this page</see> for more information.</summary>
    public sealed class ConVar : LuaObject, IEquatable<ConVar>
    {
        static readonly int ConVarId = Random.Generator.Next((int)Type.ConVar, int.MaxValue);

        public ConVar(int index) : base(index)
        {}

        public ConVar(string name) : base(LuaTable._G.InvokeObject(nameof(Global.GetConVar), name).GetIndex())
        {}

        /// <summary>Tries to convert the current string value of a ConVar to a boolean.</summary>
        /// <returns>The boolean value of the console variable. If the variable is numeric and not 0, the result will be true. Otherwise the result will be false.</returns>
        public bool GetBool() => CallBoolean(nameof(GetBool));

        /// <summary>Returns the default value of the ConVar.</summary>
        /// <returns>The default value of the console variable.</returns>
        public string GetDefault() => CallString(nameof(GetDefault));

        /// <summary>Attempts to convert the ConVar value to a float.</summary>
        /// <returns>The float value of the console variable.<para/>If the value cannot be converted to a float, it will return 0.</returns>
        public double GetFloat() => CallNumber(nameof(GetFloat));

        /// <summary>Returns the help text assigned to that convar.</summary>
        /// <returns>The help text.</returns>
        public string GetHelpText() => CallString(nameof(GetHelpText));

        /// <summary>Attempts to convert the ConVar value to a integer.</summary>
        /// <returns>The integer value of the console variable.<para/>If it fails to convert to an integer, it will return 0.<para/>All float/decimal values will be rounded down (with <see cref="math.floor"/>).</returns>
        public int GetInt() => CallInteger(nameof(GetInt));

        /// <summary>Returns the name of the ConVar.</summary>
        /// <returns>The name of the console variable.</returns>
        public string GetName() => CallString(nameof(GetName));

        /// <summary>Returns the current ConVar value as a string.</summary>
        /// <returns>The current console variable value as a string.</returns>
        public string GetString() => CallString(nameof(GetString));

        public static implicit operator ConVar(string name) => new ConVar(name);

        public static bool operator <(ConVar a, ConVar b) => a != null && b != null && a.GetFloat() < b.GetFloat();

        public static bool operator <(ConVar a, double b) => a != null && a.GetFloat() < b;

        public static bool operator <(double b, ConVar a) => a != null && b < a.GetFloat();

        public static bool operator >(ConVar a, ConVar b) => a != null && b != null && a.GetFloat() > b.GetFloat();

        public static bool operator >(ConVar a, double b) => a != null && a.GetFloat() > b;

        public static bool operator >(double b, ConVar a) => a != null && b > a.GetFloat();

        public static bool operator <=(ConVar a, ConVar b) => a != null && b != null && a.GetFloat() <= b.GetFloat();

        public static bool operator <=(ConVar a, double b) => a != null && a.GetFloat() <= b;

        public static bool operator <=(double b, ConVar a) => a != null && b <= a.GetFloat();

        public static bool operator >=(ConVar a, ConVar b) => a != null && b != null && a.GetFloat() >= b.GetFloat();

        public static bool operator >=(ConVar a, double b) => a != null && a.GetFloat() >= b;

        public static bool operator >=(double b, ConVar a) => a != null && b >= a.GetFloat();

        public static bool operator ==(ConVar a, ConVar b) => a != null && b != null && Math.Abs(a.GetFloat() - b.GetFloat()) < double.Epsilon;

        public static bool operator ==(ConVar a, double b) => a != null && Math.Abs(a.GetFloat() - b) < double.Epsilon;

        public static bool operator ==(double b, ConVar a) => a != null && Math.Abs(b - a.GetFloat()) < double.Epsilon;

        public static bool operator !=(ConVar a, ConVar b) => !(a == b);

        public static bool operator !=(ConVar a, double b) => !(a == b);

        public static bool operator !=(double b, ConVar a) => !(b == a);

        public bool Equals(ConVar other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            return ReferenceEquals(this, other) || GetFloat().Equals(other.GetFloat());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj) || GetType() != obj.GetType())
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            return obj is ConVar && Equals((ConVar)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ConVarId.GetHashCode();
            }
        }
    }
}