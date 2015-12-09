using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>
    ///     The math library is a standard Lua library that provides functions for manipulating numbers. In Garry's Mod
    ///     several additional math functions have been added.
    /// </summary>
    static class math
    {
        public const double e = 2.7182818284590452354D;
        public const double huge = 1.0D / 0.0D;
        public const double pi = 3.14159265358979323846D;

        /// <summary>Calculates the absolute value of a number (effectively removes any negative sign).</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The number to get the absolute value of.</param>
        /// <returns>Absolute value of <paramref name="x" />.</returns>
        public static double abs(LuaState luaState, double x)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(abs));
                lua_pushnumber(luaState, x);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the arc cosine of the given number.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">Value in range from -1 to +1.</param>
        /// <returns>Arc cosine of <paramref name="x" />.</returns>
        public static double acos(LuaState luaState, double x)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(acos));
                lua_pushnumber(luaState, x);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Calculates the difference between two angles.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="a">The first angle.</param>
        /// <param name="b">The second angle.</param>
        /// <returns>The difference between the angles.</returns>
        public static double AngleDifference(LuaState luaState, double a, double b)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(AngleDifference));
                lua_pushnumber(luaState, a);
                lua_pushnumber(luaState, b);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Increments a value from a start point by the given amount, up to a given upper limit.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="start">The number to start with.</param>
        /// <param name="end">The max value, this function will never return a number greater than this.</param>
        /// <param name="amount">The amount to increment the starting number by.</param>
        /// <returns>New value.</returns>
        public static double Approach(LuaState luaState, double start, double end, double amount)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(Approach));
                lua_pushnumber(luaState, start);
                lua_pushnumber(luaState, end);
                lua_pushnumber(luaState, amount);
                lua_pcall(luaState, 3, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Increments an angle towards another by specified rate.
        ///     <para />
        ///     NOTE: This function is for numbers representing angles(0-360), NOT <see cref="Structs.Angle" /> objects!
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="currentAngle">The current angle to increase.</param>
        /// <param name="targetAngle">The angle to increase towards.</param>
        /// <param name="rate">The amount to approach the target angle by.</param>
        /// <returns>Modified angle.</returns>
        public static double ApproachAngle(LuaState luaState, double currentAngle, double targetAngle, double rate)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(ApproachAngle));
                lua_pushnumber(luaState, currentAngle);
                lua_pushnumber(luaState, targetAngle);
                lua_pushnumber(luaState, rate);
                lua_pcall(luaState, 3, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the arc sine of the given number.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">Value in range from -1 to +1.</param>
        /// <returns>Arc sine of <paramref name="x" />.</returns>
        public static double asin(LuaState luaState, double x)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(asin));
                lua_pushnumber(luaState, x);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the arc tangent of the given number.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">Value in range from -1 to +1.</param>
        /// <returns>Arc tangent of <paramref name="x" />.</returns>
        public static double atan(LuaState luaState, double x)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(atan));
                lua_pushnumber(luaState, x);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>
        ///     Returns atan(<paramref name="y" /> / <paramref name="x" />) in radians. The result is between -
        ///     <see cref="pi" /> and <see cref="pi" />.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="y">Y coordinate.</param>
        /// <param name="x">X coordinate.</param>
        /// <returns>atan(<paramref name="y" /> / <paramref name="x" />) in radians.</returns>
        public static double atan2(LuaState luaState, double y, double x)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(atan2));
                lua_pushnumber(luaState, y);
                lua_pushnumber(luaState, x);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Converts a binary string into a number.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="string">Binary string to convert.</param>
        /// <returns>Base 10 number.</returns>
        public static double BinToInt(LuaState luaState, string @string)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(BinToInt));
                lua_pushstring(luaState, @string);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        // TODO: math.BSplinePoint (returns a Vector type).

        /// <summary>Basic code for Bezier-Spline algorithm.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="i"></param>
        /// <param name="k"></param>
        /// <param name="t"></param>
        /// <param name="tInc"></param>
        /// <returns></returns>
        public static double calcBSplineN(LuaState luaState, double i, double k, double t, double tInc)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(calcBSplineN));
                lua_pushnumber(luaState, i);
                lua_pushnumber(luaState, k);
                lua_pushnumber(luaState, t);
                lua_pushnumber(luaState, tInc);
                lua_pcall(luaState, 4, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Ceils or rounds a number up.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">The number to be rounded up.</param>
        /// <returns>Ceiled <paramref name="number" />.</returns>
        public static double ceil(LuaState luaState, double number)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(ceil));
                lua_pushnumber(luaState, number);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Clamps a number between a minimum and maximum value.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="input">The number to clamp.</param>
        /// <param name="min">The minimum value, this function will never return a number less than this.</param>
        /// <param name="max">The maximum value, this function will never return a number greater than this.</param>
        /// <returns>The clamped <paramref name="input" />.</returns>
        public static double Clamp(LuaState luaState, double input, double min, double max)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(Clamp));
                lua_pushnumber(luaState, input);
                lua_pushnumber(luaState, min);
                lua_pushnumber(luaState, max);
                lua_pcall(luaState, 3, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns cosine of the given angle.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="angle">Angle in radians.</param>
        /// <returns>Cosine of <paramref name="angle" />.</returns>
        public static double cos(LuaState luaState, double angle)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(cos));
                lua_pushnumber(luaState, angle);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns hyperbolic cosine of the given number.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">Value in radians.</param>
        /// <returns>Hyperbolic cosine of <paramref name="number" />.</returns>
        public static double cosh(LuaState luaState, double number)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(cosh));
                lua_pushnumber(luaState, number);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Converts radians to degrees.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="radians">Value to be converted to degrees.</param>
        /// <returns>Degrees from radians.</returns>
        public static double deg(LuaState luaState, double radians)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(deg));
                lua_pushnumber(luaState, radians);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the difference between two points in 2D space.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x1">X position of first point.</param>
        /// <param name="y1">Y position of first point.</param>
        /// <param name="x2">X position of second point.</param>
        /// <param name="y2">Y position of second point.</param>
        /// <returns>Distance between the two points.</returns>
        public static double Distance(LuaState luaState, double x1, double y1, double x2, double y2)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(Distance));
                lua_pushnumber(luaState, x1);
                lua_pushnumber(luaState, y1);
                lua_pushnumber(luaState, x2);
                lua_pushnumber(luaState, y2);
                lua_pcall(luaState, 4, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Calculates the progress of a value fraction, taking in to account given easing fractions.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="progress">Fraction of the progress to ease.</param>
        /// <param name="easeIn">Fraction of how much easing to begin with.</param>
        /// <param name="easeOut">Fraction of how much easing to end with.</param>
        /// <returns>Eased value.</returns>
        public static double EaseInOut(LuaState luaState, double progress, double easeIn, double easeOut)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(EaseInOut));
                lua_pushnumber(luaState, progress);
                lua_pushnumber(luaState, easeIn);
                lua_pushnumber(luaState, easeOut);
                lua_pcall(luaState, 3, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the x power of the euler constant.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="exponent">The exponent for the function.</param>
        /// <returns>Result.</returns>
        public static double exp(LuaState luaState, double exponent)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(exp));
                lua_pushnumber(luaState, exponent);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Floors or rounds a number down.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">The number to be rounded down.</param>
        /// <returns>Floored <paramref name="number" />.</returns>
        public static double floor(LuaState luaState, double number)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(floor));
                lua_pushnumber(luaState, number);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the modulus of the specified values.
        ///     <para />
        ///     The same effect can be achieved using the % operator.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="base">The base value.</param>
        /// <param name="modulator">The modulator.</param>
        /// <returns>The calculated modulus.</returns>
        public static double fmod(LuaState luaState, double @base, double modulator)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(fmod));
                lua_pushnumber(luaState, @base);
                lua_pushnumber(luaState, modulator);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Used to split the number value into a normalized fraction and an exponent.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputValue">The value to get the normalized fraction and the exponent from.</param>
        /// <returns>
        ///     First value is (normalized fraction) always in the range 1/2 (inclusive) to 1 (exclusive). Second value is an
        ///     exponent.
        /// </returns>
        public static Tuple<double, double> frexp(LuaState luaState, double inputValue)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(frexp));
                lua_pushnumber(luaState, inputValue);
                lua_pcall(luaState, 1, 2);
                return new Tuple<double, double>(lua_tonumber(luaState), lua_tonumber(luaState, -2));
            }
        }

        /// <summary>Used to split the number value into a normalized fraction and an exponent.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="inputValue">The value to get the normalized fraction and the exponent from.</param>
        /// <param name="normalizedFraction">Always in the range 1/2 (inclusive) to 1 (exclusive).</param>
        /// <param name="exponent">An exponent.</param>
        public static void frexp(LuaState luaState, double inputValue, out double normalizedFraction, out double exponent)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(frexp));
                lua_pushnumber(luaState, inputValue);
                lua_pcall(luaState, 1, 2);
                normalizedFraction = lua_tonumber(luaState);
                exponent = lua_tonumber(luaState, -2);
            }
        }

        /// <summary>Converts an integer to a binary (base-2) string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">Number to be converted.</param>
        /// <returns>Binary number string.</returns>
        public static string IntToBin(LuaState luaState, double number)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(IntToBin));
                lua_pushnumber(luaState, number);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Takes a normalised number and returns the floating-point representation.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="normalizedFraction">The value to get the normalized fraction and the exponent from.</param>
        /// <param name="exponent">The value to get the normalized fraction and the exponent from.</param>
        /// <returns>Result.</returns>
        public static double ldexp(LuaState luaState, double normalizedFraction, double exponent)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(ldexp));
                lua_pushnumber(luaState, normalizedFraction);
                lua_pushnumber(luaState, exponent);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>
        ///     With one argument, return the natural logarithm of <paramref name="x" /> (to <paramref name="base" />
        ///     <see cref="e" />).
        ///     <para />
        ///     With two arguments, return the logarithm of <paramref name="x" /> to the given <paramref name="base" />, calculated
        ///     as log(<paramref name="x" />)/log(<paramref name="base" />).
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The value to get the base from exponent from.</param>
        /// <param name="base">The base.</param>
        /// <returns>Result.</returns>
        public static double log(LuaState luaState, double x, double @base = e)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(log));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, @base);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>
        ///     Returns the base-10 logarithm of <paramref name="x" />. This is usually more accurate than log(
        ///     <paramref name="x" />, 10).
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The value to get the base from exponent from.</param>
        /// <returns>The base-10 logarithm of <paramref name="x" />.</returns>
        public static double log10(LuaState luaState, double x)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(log10));
                lua_pushnumber(luaState, x);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the largest value of all arguments.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="numbers">Numbers to get the largest from.</param>
        /// <returns>The largest number.</returns>
        public static double max(LuaState luaState, params double[] numbers)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(max));
                int len = 0;
                for (int i = 0; i < numbers.Length; ++i)
                {
                    lua_pushnumber(luaState, numbers[i]);
                    len++;
                }
                lua_pcall(luaState, len, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the smallest value of all arguments.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="numbers">Numbers to get the smallest from.</param>
        /// <returns>The smallest number.</returns>
        public static double min(LuaState luaState, params double[] numbers)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(min));
                int len = 0;
                for (int i = 0; i < numbers.Length; ++i)
                {
                    lua_pushnumber(luaState, numbers[i]);
                    len++;
                }
                lua_pcall(luaState, len, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the integral and fractional component of the modulo operation.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="base">The base value.</param>
        /// <param name="modulator">The modulator.</param>
        /// <returns>First result is the integral component. Second result is the fractional component.</returns>
        public static Tuple<double, double> modf(LuaState luaState, double @base, double modulator)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(modf));
                lua_pushnumber(luaState, @base);
                lua_pushnumber(luaState, modulator);
                lua_pcall(luaState, 2, 2);
                return new Tuple<double, double>(lua_tonumber(luaState), lua_tonumber(luaState, -2));
            }
        }

        /// <summary>Returns the integral and fractional component of the modulo operation.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="base">The base value.</param>
        /// <param name="modulator">The modulator.</param>
        /// <param name="integral">The integral component.</param>
        /// <param name="fractional">The fractional component.</param>
        public static void modf(LuaState luaState, double @base, double modulator, out double integral, out double fractional)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(modf));
                lua_pushnumber(luaState, @base);
                lua_pushnumber(luaState, modulator);
                lua_pcall(luaState, 2, 2);
                integral = lua_tonumber(luaState);
                fractional = lua_tonumber(luaState, -2);
            }
        }

        /// <summary>Normalizes angle, so it returns value between -180 and 180.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="angle">The angle to normalize, in degrees.</param>
        /// <returns>The normalized <paramref name="angle" />, in the range of -180 to 180 degrees.</returns>
        public static double NormalizeAngle(LuaState luaState, double angle)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(NormalizeAngle));
                lua_pushnumber(luaState, angle);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>
        ///     Returns <paramref name="x" /> raised to the power <paramref name="y" />.
        ///     <para />
        ///     In particular, math.pow(1.0, <paramref name="x" />) and math.pow(<paramref name="x" />, 0.0) always return 1.0,
        ///     even when <paramref name="x" /> is a zero or a NaN. If both <paramref name="x" /> and <paramref name="y" /> are
        ///     finite, <paramref name="x" /> is negative, and <paramref name="y" /> is not an integer then math.pow(
        ///     <paramref name="x" />, <paramref name="y" />) is undefined.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">Base.</param>
        /// <param name="y">Exponent.</param>
        /// <returns>Returns <paramref name="x" /> raised to the power <paramref name="y" />.</returns>
        public static double pow(LuaState luaState, double x, double y)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(pow));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, y);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Converts an angle in degrees to it's equivalent in radians.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="degrees">The angle measured in degrees.</param>
        /// <returns>Radians from degrees.</returns>
        public static double rad(LuaState luaState, double degrees)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(rad));
                lua_pushnumber(luaState, degrees);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns a random float between <paramref name="min" /> and <paramref name="max" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>Random float between <paramref name="min" /> and <paramref name="max" />.</returns>
        public static double Rand(LuaState luaState, double min, double max)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(Rand));
                lua_pushnumber(luaState, min);
                lua_pushnumber(luaState, max);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns a random integer between <paramref name="min" /> and <paramref name="max" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>Random integer between <paramref name="min" /> and <paramref name="max" />.</returns>
        public static int random(LuaState luaState, int min, int max)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(random));
                lua_pushinteger(luaState, min);
                lua_pushinteger(luaState, max);
                lua_pcall(luaState, 2, 1);
                return lua_tointeger(luaState);
            }
        }

        /// <summary>
        ///     Seeds the <paramref name="seed" /> for the random generator, which will cause <see cref="random" /> to return
        ///     the same sequence of numbers.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="seed">The new seed.</param>
        public static void randomseed(LuaState luaState, double seed)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(randomseed));
                lua_pushnumber(luaState, seed);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Remaps the value from one range to another.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value.</param>
        /// <param name="inMin">The minimum of the initial range.</param>
        /// <param name="inMax">The maximum of the initial range.</param>
        /// <param name="outMin">The minimum of new range.</param>
        /// <param name="outMax">The maximum of new range.</param>
        /// <returns>The number in the new range.</returns>
        public static double Remap(LuaState luaState, double value, double inMin, double inMax, double outMin, double outMax)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(Remap));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, inMin);
                lua_pushnumber(luaState, inMax);
                lua_pushnumber(luaState, outMin);
                lua_pushnumber(luaState, outMax);
                lua_pcall(luaState, 5, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Rounds the given value to the nearest whole number or to the given decimal places.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="value">The value to round.</param>
        /// <param name="decimals">The decimal places to round to.</param>
        /// <returns>The rounded <paramref name="value" />.</returns>
        public static double Round(LuaState luaState, double value, double decimals = 0.0D)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(Round));
                lua_pushnumber(luaState, value);
                lua_pushnumber(luaState, decimals);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns sine of the given <paramref name="angle" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="angle">Angle in radians.</param>
        /// <returns>Sine of the given <paramref name="angle" />.</returns>
        public static double sin(LuaState luaState, double angle)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(sin));
                lua_pushnumber(luaState, angle);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns hyperbolic sine of the given <paramref name="number" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">Value in radians.</param>
        /// <returns>Hyperbolic sine of the given <paramref name="number" />.</returns>
        public static double sinh(LuaState luaState, double number)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(sinh));
                lua_pushnumber(luaState, number);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns square root of the given <paramref name="number" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">Value to get the square root of.</param>
        /// <returns>Square root of the given <paramref name="number" />.</returns>
        public static double sqrt(LuaState luaState, double number)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(sqrt));
                lua_pushnumber(luaState, number);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns tangent of the given <paramref name="angle" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="angle">Angle in radians.</param>
        /// <returns>Tangent of the given <paramref name="angle" />.</returns>
        public static double tan(LuaState luaState, double angle)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(tan));
                lua_pushnumber(luaState, angle);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns hyperbolic tangent of the given <paramref name="number" />.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">Value in radians.</param>
        /// <returns>Hyperbolic tangent of the given <paramref name="number" />.</returns>
        public static double tanh(LuaState luaState, double number)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(tanh));
                lua_pushnumber(luaState, number);
                lua_pcall(luaState, 1, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>
        ///     Returns the fraction of where the current time is relative to the <paramref name="start" /> and
        ///     <paramref name="end" /> times.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="start">Start time in seconds.</param>
        /// <param name="end">End time in seconds.</param>
        /// <param name="current">Current time in seconds.</param>
        /// <returns>
        ///     The fraction of where the current time is relative to the <paramref name="start" /> and
        ///     <paramref name="end" /> times.
        /// </returns>
        public static double TimeFraction(LuaState luaState, double start, double end, double current)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(TimeFraction));
                lua_pushnumber(luaState, start);
                lua_pushnumber(luaState, end);
                lua_pushnumber(luaState, current);
                lua_pcall(luaState, 3, 1);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Rounds towards zero.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="number">The number to truncate.</param>
        /// <param name="digits">The amount of digits to keep after the point.</param>
        /// <returns>Truncated <paramref name="number" />.</returns>
        public static double Truncate(LuaState luaState, double number, double digits)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(math));
                lua_getfield(luaState, -1, nameof(Truncate));
                lua_pushnumber(luaState, number);
                lua_pushnumber(luaState, digits);
                lua_pcall(luaState, 2, 1);
                return lua_tonumber(luaState);
            }
        }
    }
}