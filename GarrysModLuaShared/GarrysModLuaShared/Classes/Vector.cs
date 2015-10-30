using System;

namespace GarrysModLuaShared.Classes
{
    /// <summary>Representation of a line with direction and length. Use <see cref="Global.Vector"/> function to create an instance of this object.</summary>
    public sealed class Vector : LuaObject, IEquatable<Vector>
    {
        static readonly int VectorId = Random.Generator.Next((int)Type.Vector, int.MaxValue);
        double _x, _y, _z;

        public Vector(int index) : base(index)
        {}

        /// <summary>Creates a new instance of this object.</summary>
        /// <param name="x">The x value for new vector.</param>
        /// <param name="y">The y value for new vector.</param>
        /// <param name="z">The z value for new vector.</param>
        public Vector(double x, double y, double z) : base(LuaTable._G.InvokeObject(nameof(Vector), x, y, z).GetIndex())
        {
            _x = x;
            _y = y;
            _z = z;
        }

        /// <summary>The X component of the vector (+forward/-backward; East/West).</summary>
        public double x
        {
            get
            {
                return _x = GetFieldNumber(nameof(x));
            }
            set
            {
                SetField(nameof(x), _x = value);
            }
        }

        /// <summary>The Y component of the vector (+left/-right; North/South).</summary>
        public double y
        {
            get
            {
                return _y = GetFieldNumber(nameof(y));
            }
            set
            {
                SetField(nameof(y), _y = value);
            }
        }

        /// <summary>The Z component of the vector (+up/-down).</summary>
        public double z
        {
            get
            {
                return _z = GetFieldNumber(nameof(z));
            }
            set
            {
                SetField(nameof(z), _z = value);
            }
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    case 2:
                        return z;
                    default:
                        return default(double);
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        x = value;
                        return;
                    case 1:
                        y = value;
                        return;
                    case 2:
                        z = value;
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
                    case nameof(x):
                        return x;
                    case nameof(y):
                        return y;
                    case nameof(z):
                        return z;
                    default:
                        return default(double);
                }
            }
            set
            {
                switch (index.ToLowerInvariant())
                {
                    case nameof(x):
                        x = value;
                        return;
                    case nameof(y):
                        y = value;
                        return;
                    case nameof(z):
                        z = value;
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
                    case nameof(x):
                        return x;
                    case nameof(y):
                        return y;
                    case nameof(z):
                        return z;
                    default:
                        return default(double);
                }
            }
            set
            {
                switch (index.ToString().ToLowerInvariant())
                {
                    case nameof(x):
                        x = value;
                        return;
                    case nameof(y):
                        y = value;
                        return;
                    case nameof(z):
                        z = value;
                        return;
                }
            }
        }

        /// <summary>Adds the values of the second vector to the orignal vector, this function can be used to avoid garbage collection.</summary>
        /// <param name="vector">The other vector.</param>
        public void Add(Vector vector) => CallVoid(nameof(Add), vector);

        /// <summary>Returns an angle representing the normal of the vector.</summary>
        /// <returns>The angle/direction of the vector.</returns>
        public Angle Angle() => CallObject(nameof(Angle)).ToAngle();

        /// <summary>Returns the angle of the vector, but instead of assuming that up is Vector( 0, 0, 1 ) (like <see cref="Angle"/> does) you can specify which direction is 'up' for the angle.</summary>
        /// <param name="up">The up direction vector.</param>
        /// <returns>The angle of the vector.</returns>
        public Angle AngleEx(Vector up) => CallObject(nameof(AngleEx), up).ToAngle();

        /// <summary>Calculates the cross product of this vector and the passed one.<para/>The cross product of two vectors is a 3-dimensional vector with a direction perpendicular(at right angles) to both of them(according to the right-hand rule), and magnitude equal to the area of parallelogram they span.This is defined as the product of the magnitudes, the sine of the angle between them, and unit (normal) vector n defined by the right-hand rule:<para/>a × b = |a| |b| sin(θ) n̂<para/>where a and b are vectors, and n̂ is a unit vector(magnitude of 1) perpendicular to both.</summary>
        /// <param name="otherVector">Vector to calculate the cross product with.</param>
        /// <returns>The cross product of the two vectors.</returns>
        public Vector Cross(Vector otherVector) => CallObject(nameof(Cross), otherVector).ToVector();

        /// <summary>Returns the pythagorean distance between the vector and the other vector.</summary>
        /// <param name="otherVector">The vector to get the distance to.</param>
        /// <returns>Distance between the vectors.</returns>
        public double Distance(Vector otherVector) => CallNumber(nameof(Distance), otherVector);

        /// <summary>Returns the squared distance of 2 vectors, this is faster than <see cref="Distance"/> as calculating the square root is an expensive process.</summary>
        /// <param name="otherVector">The vector to calculate the distance to.</param>
        /// <returns>Squared distance to the vector.</returns>
        public double DistToSqr(Vector otherVector) => CallNumber(nameof(DistToSqr), otherVector);

        /// <summary>Returns the dot product of this vector and the passed one.<para/>The dot product of two vectors is the product of their magnitudes(lengths), and the cosine of the angle between them:<para/>a · b = |a| |b| cos(θ)<para/>where a and b are vectors.See Vector:Length for obtaining magnitudes.<para/>A dot product returns just the cosine of the angle if both vectors are normalized, and zero if the vectors are at right angles to each other.</summary>
        /// <param name="otherVector">The vector to calculate the dot product with.</param>
        /// <returns>The dot product between the two vectors.</returns>
        public double Dot(Vector otherVector) => CallNumber(nameof(Dot), otherVector);

        /// <summary>Returns a normalized version of the vector. Normalized means vector with same direction but with length of 1.<para/>This does not affect the vector you call it on; to do this, use <see cref="Normalize"/>.</summary>
        /// <returns>Normalized version of the vector.</returns>
        public Vector GetNormalized() => CallObject(nameof(GetNormalized)).ToVector();

        /// <summary>Returns if the vector is equal to another vector with the given tolerance.</summary>
        /// <param name="compare">The vector to compare to.</param>
        /// <param name="tolerance">The tolerance range.</param>
        /// <returns>Are the vectors equal or not.</returns>
        public bool IsEqualTol(Vector compare, double tolerance) => CallBoolean(nameof(IsEqualTol), compare, tolerance);

        /// <summary>Checks whenever all fields of the vector are 0.</summary>
        /// <returns>Do all fields of the vector equal 0 or not.</returns>
        public bool IsZero() => CallBoolean(nameof(IsZero));

        /// <summary>Returns the Euclidean length of the vector: √ x² + y² + z².</summary>
        /// <returns>Length of the vector.</returns>
        public double Length() => CallNumber(nameof(Length));

        /// <summary>Returns the length of the vector in two dimensions, without the Z axis.</summary>
        /// <returns>Length of the vector in two dimensions, √ x² + y².</returns>
        public double Length2D() => CallNumber(nameof(Length2D));

        /// <summary>Returns the squared length of the vectors x and y value, x² + y².<para/>This is faster than <see cref="Length2D"/> as calculating the square root is an expensive process.</summary>
        /// <returns>Squared length of the vector in two dimensions.</returns>
        public double Length2DSqr() => CallNumber(nameof(Length2DSqr));

        /// <summary>Returns the squared length of the vector, x² + y² + z².<para/>This is faster than <see cref="Length"/> as calculating the square root is an expensive process.</summary>
        /// <returns>Squared length of the vector.</returns>
        public double LengthSqr() => CallNumber(nameof(LengthSqr));

        /// <summary>Scales the vector by the given number, that means x, y and z are multiplied by that value.</summary>
        /// <param name="multiplier">The value to scale the vector with.</param>
        public void Mul(double multiplier) => CallVoid(nameof(Mul), multiplier);

        /// <summary>Normalizes the given vector. This changes the vector you call it on, if you want to return a normalized copy without affecting the original, use <see cref="GetNormalized"/>.</summary>
        public void Normalize() => CallVoid(nameof(Normalize));

        /// <summary>Rotates a vector by the given angle. Doesn't return anything, but rather changes the original vector.</summary>
        /// <param name="rotation">The angle to rotate the vector by.</param>
        public void Rotate(Angle rotation) => CallVoid(nameof(Rotate), rotation);

        /// <summary>Copies the values from the second vector to the first vector.</summary>
        /// <param name="vector">The vector to copy from.</param>
        public void Set(Vector vector) => CallVoid(nameof(Set), vector);

        /// <summary>Substracts the values of the second vector from the orignal vector, this function can be used to avoid garbage collection.</summary>
        /// <param name="vector">The other vector.</param>
        public void Sub(Vector vector) => CallVoid(nameof(Sub), vector);

        //#if CLIENT
        // TODO: Vector.ToColor (after implementing structures).

        // TODO: Vector.ToScreen (after implementing structures).
        //#endif

        /// <summary>Returns whenever the given vector is in a box created by the 2 other vectors.</summary>
        /// <param name="boxStart">The first vector.</param>
        /// <param name="boxEnd">The second vector.</param>
        /// <returns>Is the vector in the box or not.</returns>
        public bool WithinAABox(Vector boxStart, Vector boxEnd) => CallBoolean(nameof(WithinAABox), boxStart, boxEnd);

        /// <summary>Sets x, y and z to 0. This function is faster than doing it manually.</summary>
        public void Zero() => CallVoid(nameof(Zero));

        public static Vector operator +(Vector a) => new Vector(+(a.x), +(a.y), +(a.z));

        public static Vector operator -(Vector a) => new Vector(-(a.x), -(a.y), -(a.z));

        public static Vector operator ~(Vector a) => new Vector(~((long)a.x), ~((long)a.y), ~((long)a.z));

        public static Vector operator ++(Vector a) => new Vector(a.x + 1, a.y + 1, a.z + 1);

        public static Vector operator --(Vector a) => new Vector(a.x - 1, a.y - 1, a.z - 1);

        public static implicit operator Vector(int value) => new Vector(value, value, value);

        public static implicit operator Vector(long value) => new Vector(value, value, value);

        public static implicit operator Vector(double value) => new Vector(value, value, value);

        public static Vector operator *(Vector a, Vector b) => new Vector(a.x * b.x, a.y * b.y, a.z * b.z);

        public static Vector operator *(Vector a, double b) => new Vector(a.x * b, a.y * b, a.z * b);

        public static Vector operator *(double b, Vector a) => new Vector(b * a.x, b * a.y, b * a.z);

        public static Vector operator /(Vector a, Vector b) => new Vector(a.x / b.x, a.y / b.y, a.z / b.z);

        public static Vector operator /(Vector a, double b) => new Vector(a.x / b, a.y / b, a.z / b);

        public static Vector operator /(double b, Vector a) => new Vector(b / a.x, b / a.y, b / a.z);

        public static Vector operator %(Vector a, Vector b) => new Vector(a.x % b.x, a.y % b.y, a.z % b.z);

        public static Vector operator %(Vector a, double b) => new Vector(a.x % b, a.y % b, a.z % b);

        public static Vector operator %(double b, Vector a) => new Vector(b % a.x, b % a.y, b % a.z);

        public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y, a.z + b.z);

        public static Vector operator +(Vector a, double b) => new Vector(a.x + b, a.y + b, a.z + b);

        public static Vector operator +(double b, Vector a) => new Vector(b + a.x, b + a.y, b + a.z);

        public static Vector operator -(Vector a, Vector b) => new Vector(a.x - b.x, a.y - b.y, a.z - b.z);

        public static Vector operator -(Vector a, double b) => new Vector(a.x - b, a.y - b, a.z - b);

        public static Vector operator -(double b, Vector a) => new Vector(b - a.x, b - a.y, b - a.z);

        public static Vector operator <<(Vector a, int b) => new Vector((long)a.x << b, (long)a.y << b, (long)a.z << b);

        public static Vector operator >>(Vector a, int b) => new Vector((long)a.x >> b, (long)a.y >> b, (long)a.z >> b);

        public static bool operator <(Vector a, Vector b) => a != null && b != null && a.x < b.x && a.y < b.y && a.z < b.z;

        public static bool operator <(Vector a, double b) => a != null && a.x < b && a.y < b && a.z < b;

        public static bool operator <(double b, Vector a) => a != null && b < a.x && b < a.y && b < a.z;

        public static bool operator >(Vector a, Vector b) => a != null && b != null && a.x > b.x && a.y > b.y && a.z > b.z;

        public static bool operator >(Vector a, double b) => a != null && a.x > b && a.y > b && a.z > b;

        public static bool operator >(double b, Vector a) => a != null && b > a.x && b > a.y && b > a.z;

        public static bool operator <=(Vector a, Vector b) => a != null && b != null && a.x <= b.x && a.y <= b.y && a.z <= b.z;

        public static bool operator <=(Vector a, double b) => a != null && a.x <= b && a.y <= b && a.z <= b;

        public static bool operator <=(double b, Vector a) => a != null && b <= a.x && b <= a.y && b <= a.z;

        public static bool operator >=(Vector a, Vector b) => a != null && b != null && a.x >= b.x && a.y >= b.y && a.z >= b.z;

        public static bool operator >=(Vector a, double b) => a != null && a.x >= b && a.y >= b && a.z >= b;

        public static bool operator >=(double b, Vector a) => a != null && b >= a.x && b >= a.y && b >= a.z;

        public static bool operator ==(Vector a, Vector b) => a != null && b != null && Math.Abs(a.x - b.x) < double.Epsilon && Math.Abs(a.y - b.y) < double.Epsilon && Math.Abs(a.z - b.z) < double.Epsilon;

        public static bool operator ==(Vector a, double b) => a != null && Math.Abs(a.x - b) < double.Epsilon && Math.Abs(a.y - b) < double.Epsilon && Math.Abs(a.z - b) < double.Epsilon;

        public static bool operator ==(double b, Vector a) => a != null && Math.Abs(b - a.x) < double.Epsilon && Math.Abs(b - a.y) < double.Epsilon && Math.Abs(b - a.z) < double.Epsilon;

        public static bool operator !=(Vector a, Vector b) => !(a == b);

        public static bool operator !=(Vector a, double b) => !(a == b);

        public static bool operator !=(double b, Vector a) => !(b == a);

        public static Vector operator &(Vector a, Vector b) => new Vector((long)a.x & (long)b.x, (long)a.y & (long)b.y, (long)a.z & (long)b.z);

        public static Vector operator &(Vector a, long b) => new Vector((long)a.x & b, (long)a.y & b, (long)a.z & b);

        public static Vector operator &(long b, Vector a) => new Vector(b & (long)a.x, b & (long)a.y, b & (long)a.z);

        public static Vector operator ^(Vector a, Vector b) => new Vector((long)a.x ^ (long)b.x, (long)a.y ^ (long)b.y, (long)a.z ^ (long)b.z);

        public static Vector operator ^(Vector a, long b) => new Vector((long)a.x ^ b, (long)a.y ^ b, (long)a.z ^ b);

        public static Vector operator ^(long b, Vector a) => new Vector(b ^ (long)a.x, b ^ (long)a.y, b ^ (long)a.z);

        public static Vector operator |(Vector a, Vector b) => new Vector((long)a.x | (long)b.x, (long)a.y | (long)b.y, (long)a.z | (long)b.z);

        public static Vector operator |(Vector a, long b) => new Vector((long)a.x | b, (long)a.y | b, (long)a.z | b);

        public static Vector operator |(long b, Vector a) => new Vector(b | (long)a.x, b | (long)a.y, b | (long)a.z);

        public bool Equals(Vector other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return _x.Equals(other._x) && _y.Equals(other._y) && _z.Equals(other._z);
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
            return obj is Vector && Equals((Vector)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = VectorId.GetHashCode();
                hashCode = (hashCode * 396) ^ _x.GetHashCode();
                hashCode = (hashCode * 396) ^ _y.GetHashCode();
                hashCode = (hashCode * 396) ^ _z.GetHashCode();
                return hashCode;
            }
        }
    }
}