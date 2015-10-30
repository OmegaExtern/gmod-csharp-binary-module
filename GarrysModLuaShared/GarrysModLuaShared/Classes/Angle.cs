using System;

namespace GarrysModLuaShared.Classes
{
    /// <summary>Representation of a three-dimensional Euler angle. Use <see cref="Global.Angle"/> function to create an instance of this object.</summary>
    public sealed class Angle : LuaObject, IEquatable<Angle>
    {
        static readonly int AngleId = Random.Generator.Next((int)Type.Angle, int.MaxValue);
        double _pitch, _yaw, _roll, _p, _y, _r;

        public Angle(int index) : base(index)
        {
        }

        /// <summary>Creates a new instance of this object.</summary>
        /// <param name="pitch">The pitch value for new angle.</param>
        /// <param name="yaw">The yaw value for new angle.</param>
        /// <param name="roll">The roll value for new angle.</param>
        public Angle(double pitch = default(double), double yaw = default(double), double roll = default(double)) : base(LuaTable._G.InvokeObject(nameof(Angle), pitch, yaw, roll).GetIndex())
        {
            _p = _pitch = pitch;
            _y = _yaw = yaw;
            _r = _roll = roll;
        }

        /// <summary>The pitch component of the angle (rotation around the X axis). +Down/-Up.</summary>
        public double pitch
        {
            get
            {
                return _p = _pitch = GetFieldNumber(nameof(pitch));
            }
            set
            {
                SetField(nameof(pitch), _p = _pitch = value);
            }
        }

        /// <summary>The yaw component of the angle (rotation around the Y axis). +Left/-Right.</summary>
        public double yaw
        {
            get
            {
                return _y = _yaw = GetFieldNumber(nameof(yaw));
            }
            set
            {
                SetField(nameof(yaw), _y = _yaw = value);
            }
        }

        /// <summary>The roll component of the angle (rotation around the Z axis). +Right/-Left.</summary>
        public double roll
        {
            get
            {
                return _r = _roll = GetFieldNumber(nameof(roll));
            }
            set
            {
                SetField(nameof(roll), _r = _roll = value);
            }
        }

        /// <summary>The pitch component of the angle (rotation around the X axis). +Down/-Up.</summary>
        public double p
        {
            get
            {
                return _pitch = _p = GetFieldNumber(nameof(p));
            }
            set
            {
                SetField(nameof(p), _pitch = _p = value);
            }
        }

        /// <summary>The yaw component of the angle (rotation around the Y axis). +Left/-Right.</summary>
        public double y
        {
            get
            {
                return _yaw = _y = GetFieldNumber(nameof(y));
            }
            set
            {
                SetField(nameof(y), _yaw = _y = value);
            }
        }

        /// <summary>The roll component of the angle (rotation around the Z axis). +Right/-Left.</summary>
        public double r
        {
            get
            {
                return _roll = _r = GetFieldNumber(nameof(r));
            }
            set
            {
                SetField(nameof(r), _roll = _r = value);
            }
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return pitch;
                    case 1:
                        return yaw;
                    case 2:
                        return roll;
                    default:
                        return default(double);
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        pitch = value;
                        return;
                    case 1:
                        yaw = value;
                        return;
                    case 2:
                        roll = value;
                        return;
                }
            }
        }

        public double this[string index]
        {
            get
            {
                switch (index.ToLowerInvariant())
                {
                    case nameof(pitch):
                    case nameof(p):
                        return pitch;
                    case nameof(yaw):
                    case nameof(y):
                        return yaw;
                    case nameof(roll):
                    case nameof(r):
                        return roll;
                    default:
                        return default(double);
                }
            }
            set
            {
                switch (index.ToLowerInvariant())
                {
                    case nameof(pitch):
                    case nameof(p):
                        pitch = value;
                        return;
                    case nameof(yaw):
                    case nameof(y):
                        yaw = value;
                        return;
                    case nameof(roll):
                    case nameof(r):
                        roll = value;
                        return;
                }
            }
        }

        public double this[char index]
        {
            get
            {
                switch (index.ToString().ToLowerInvariant())
                {
                    case nameof(p):
                        return pitch;
                    case nameof(y):
                        return yaw;
                    case nameof(r):
                        return roll;
                    default:
                        return default(double);
                }
            }
            set
            {
                switch (index.ToString().ToLowerInvariant())
                {
                    case nameof(p):
                        pitch = value;
                        return;
                    case nameof(y):
                        yaw = value;
                        return;
                    case nameof(r):
                        roll = value;
                        return;
                }
            }
        }

        /// <summary>Returns a normal vector facing in the direction that the angle points.</summary>
        /// <returns>The forward direction of the angle.</returns>
        public Vector Forward() => CallObject(nameof(Forward)).ToVector();

        /// <summary>Returns whether the pitch, yaw and roll are 0 or not.</summary>
        /// <returns>Whether the pitch, yaw and roll are 0 or not.</returns>
        public bool IsZero() => CallBoolean(nameof(IsZero));

        /// <summary>Normalizes the angles by applying a module with 360 to pitch, yaw and roll.</summary>
        public void Normalize() => CallVoid(nameof(Normalize));

        /// <summary>Returns a normal vector facing in the direction that points right relative to the angle's direction.</summary>
        /// <returns>The right direction of the angle.</returns>
        public Vector Right() => CallObject(nameof(Right)).ToVector();

        /// <summary>Rotates the angle around the specified axis by the specified degrees.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="rotation">The degrees to rotate around the specified axis.</param>
        public void RotateAroundAxis(Vector axis, double rotation) => CallVoid(nameof(RotateAroundAxis), axis, rotation);

        /// <summary>Copies pitch, yaw and roll from the second angle to the first.</summary>
        /// <param name="originalAngle">The angle to copy the values from.</param>
        public void Set(Angle originalAngle) => CallVoid(nameof(Set), originalAngle);

        /// <summary>Snaps the angle to nearest interval of degrees.<para/>NOTE: This will modify the original angle too!</summary>
        /// <param name="axis">The component/axis to snap. Can be either "p"/"pitch", "y"/"yaw" or "r"/"roll".</param>
        /// <param name="target">The target angle snap interval.</param>
        /// <returns>The snapped angle.</returns>
        public Angle SnapTo(string axis, double target) => CallObject(nameof(SnapTo), axis, target).ToAngle();

        /// <summary>Returns a normal vector facing in the direction that points up relative to the angle's direction.</summary>
        /// <returns>The up direction of the angle.</returns>
        public Vector Up() => CallObject(nameof(Up)).ToVector();

        /// <summary>Sets pitch, yaw and roll to 0. This function is faster than doing it manually.</summary>
        public void Zero() => CallVoid(nameof(Zero));

        public static Angle operator +(Angle a) => new Angle(+(a.pitch), +(a.yaw), +(a.roll));

        public static Angle operator -(Angle a) => new Angle(-(a.pitch), -(a.yaw), -(a.roll));

        public static Angle operator ~(Angle a) => new Angle(~((long)a.pitch), ~((long)a.yaw), ~((long)a.roll));

        public static Angle operator ++(Angle a) => new Angle(a.pitch + 1, a.yaw + 1, a.roll + 1);

        public static Angle operator --(Angle a) => new Angle(a.pitch - 1, a.yaw - 1, a.roll - 1);

        public static implicit operator Angle(int value) => new Angle(value, value, value);

        public static implicit operator Angle(long value) => new Angle(value, value, value);

        public static implicit operator Angle(double value) => new Angle(value, value, value);

        public static Angle operator *(Angle a, Angle b) => new Angle(a.pitch * b.pitch, a.yaw * b.yaw, a.roll * b.roll);

        public static Angle operator *(Angle a, double b) => new Angle(a.pitch * b, a.yaw * b, a.roll * b);

        public static Angle operator *(double b, Angle a) => new Angle(b * a.pitch, b * a.yaw, b * a.roll);

        public static Angle operator /(Angle a, Angle b) => new Angle(a.pitch / b.pitch, a.yaw / b.yaw, a.roll / b.roll);

        public static Angle operator /(Angle a, double b) => new Angle(a.pitch / b, a.yaw / b, a.roll / b);

        public static Angle operator /(double b, Angle a) => new Angle(b / a.pitch, b / a.yaw, b / a.roll);

        public static Angle operator %(Angle a, Angle b) => new Angle(a.pitch % b.pitch, a.yaw % b.yaw, a.roll % b.roll);

        public static Angle operator %(Angle a, double b) => new Angle(a.pitch % b, a.yaw % b, a.roll % b);

        public static Angle operator %(double b, Angle a) => new Angle(b % a.pitch, b % a.yaw, b % a.roll);

        public static Angle operator +(Angle a, Angle b) => new Angle(a.pitch + b.pitch, a.yaw + b.yaw, a.roll + b.roll);

        public static Angle operator +(Angle a, double b) => new Angle(a.pitch + b, a.yaw + b, a.roll + b);

        public static Angle operator +(double b, Angle a) => new Angle(b + a.pitch, b + a.yaw, b + a.roll);

        public static Angle operator -(Angle a, Angle b) => new Angle(a.pitch - b.pitch, a.yaw - b.yaw, a.roll - b.roll);

        public static Angle operator -(Angle a, double b) => new Angle(a.pitch - b, a.yaw - b, a.roll - b);

        public static Angle operator -(double b, Angle a) => new Angle(b - a.pitch, b - a.yaw, b - a.roll);

        public static Angle operator <<(Angle a, int b) => new Angle((long)a.pitch << b, (long)a.yaw << b, (long)a.roll << b);

        public static Angle operator >>(Angle a, int b) => new Angle((long)a.pitch >> b, (long)a.yaw >> b, (long)a.roll >> b);

        public static bool operator <(Angle a, Angle b) => a != null && b != null && a.pitch < b.pitch && a.yaw < b.yaw && a.roll < b.roll;

        public static bool operator <(Angle a, double b) => a != null && a.pitch < b && a.yaw < b && a.roll < b;

        public static bool operator <(double b, Angle a) => a != null && b < a.pitch && b < a.yaw && b < a.roll;

        public static bool operator >(Angle a, Angle b) => a != null && b != null && a.pitch > b.pitch && a.yaw > b.yaw && a.roll > b.roll;

        public static bool operator >(Angle a, double b) => a != null && a.pitch > b && a.yaw > b && a.roll > b;

        public static bool operator >(double b, Angle a) => a != null && b > a.pitch && b > a.yaw && b > a.roll;

        public static bool operator <=(Angle a, Angle b) => a != null && b != null && a.pitch <= b.pitch && a.yaw <= b.yaw && a.roll <= b.roll;

        public static bool operator <=(Angle a, double b) => a != null && a.pitch <= b && a.yaw <= b && a.roll <= b;

        public static bool operator <=(double b, Angle a) => a != null && b <= a.pitch && b <= a.yaw && b <= a.roll;

        public static bool operator >=(Angle a, Angle b) => a != null && b != null && a.pitch >= b.pitch && a.yaw >= b.yaw && a.roll >= b.roll;

        public static bool operator >=(Angle a, double b) => a != null && a.pitch >= b && a.yaw >= b && a.roll >= b;

        public static bool operator >=(double b, Angle a) => a != null && b >= a.pitch && b >= a.yaw && b >= a.roll;

        public static bool operator ==(Angle a, Angle b) => a != null && b != null && Math.Abs(a.pitch - b.pitch) < double.Epsilon && Math.Abs(a.yaw - b.yaw) < double.Epsilon && Math.Abs(a.roll - b.roll) < double.Epsilon;

        public static bool operator ==(Angle a, double b) => a != null && Math.Abs(a.pitch - b) < double.Epsilon && Math.Abs(a.yaw - b) < double.Epsilon && Math.Abs(a.roll - b) < double.Epsilon;

        public static bool operator ==(double b, Angle a) => a != null && Math.Abs(b - a.pitch) < double.Epsilon && Math.Abs(b - a.yaw) < double.Epsilon && Math.Abs(b - a.roll) < double.Epsilon;

        public static bool operator !=(Angle a, Angle b) => !(a == b);

        public static bool operator !=(Angle a, double b) => !(a == b);

        public static bool operator !=(double b, Angle a) => !(b == a);

        public static Angle operator &(Angle a, Angle b) => new Angle((long)a.pitch & (long)b.pitch, (long)a.yaw & (long)b.yaw, (long)a.roll & (long)b.roll);

        public static Angle operator &(Angle a, long b) => new Angle((long)a.pitch & b, (long)a.yaw & b, (long)a.roll & b);

        public static Angle operator &(long b, Angle a) => new Angle(b & (long)a.pitch, b & (long)a.yaw, b & (long)a.roll);

        public static Angle operator ^(Angle a, Angle b) => new Angle((long)a.pitch ^ (long)b.pitch, (long)a.yaw ^ (long)b.yaw, (long)a.roll ^ (long)b.roll);

        public static Angle operator ^(Angle a, long b) => new Angle((long)a.pitch ^ b, (long)a.yaw ^ b, (long)a.roll ^ b);

        public static Angle operator ^(long b, Angle a) => new Angle(b ^ (long)a.pitch, b ^ (long)a.yaw, b ^ (long)a.roll);

        public static Angle operator |(Angle a, Angle b) => new Angle((long)a.pitch | (long)b.pitch, (long)a.yaw | (long)b.yaw, (long)a.roll | (long)b.roll);

        public static Angle operator |(Angle a, long b) => new Angle((long)a.pitch | b, (long)a.yaw | b, (long)a.roll | b);

        public static Angle operator |(long b, Angle a) => new Angle(b | (long)a.pitch, b | (long)a.yaw, b | (long)a.roll);

        public bool Equals(Angle other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return _pitch.Equals(other._pitch) && _yaw.Equals(other._yaw) && _roll.Equals(other._roll) && _p.Equals(other._p) && _y.Equals(other._y) && _r.Equals(other._r);
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
            return obj is Angle && Equals((Angle)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = AngleId.GetHashCode();
                hashCode = (hashCode * 396) ^ _pitch.GetHashCode();
                hashCode = (hashCode * 396) ^ _yaw.GetHashCode();
                hashCode = (hashCode * 396) ^ _roll.GetHashCode();
                hashCode = (hashCode * 396) ^ _p.GetHashCode();
                hashCode = (hashCode * 396) ^ _y.GetHashCode();
                hashCode = (hashCode * 396) ^ _r.GetHashCode();
                return hashCode;
            }
        }
    }
}