namespace GarrysModLuaShared.Classes
{
    /// <summary>
    ///     Representation of a mathematical construct that allows Vectors to be transformed. This object can be created
    ///     with <see cref="Global.Matrix" /> function.
    /// </summary>
    public sealed class VMatrix : LuaObject
    {
        static readonly int VMatrixId = Random.Generator.Next((int)Type.Matrix, int.MaxValue);

        public VMatrix(int index) : base(index) { }

        public VMatrix(LuaTable data) : base(LuaTable._G.InvokeObject(nameof(Global.Matrix), data).GetIndex()) { }

        /// <summary>Returns the absolute rotation of the matrix.</summary>
        /// <returns>Absolute rotation of the matrix.</returns>
        public Angle GetAngles() => CallObject(nameof(GetAngles)).ToAngle();

        /// <summary>Returns a specific field in the matrix.</summary>
        /// <param name="row">Row of the field whose value is to be retrieved, from 1 to 4.</param>
        /// <param name="column">Column of the field whose value is to be retrieved, from 1 to 4.</param>
        /// <returns>The value of the specified field.</returns>
        public double GetField(byte row, byte column) => CallNumber(nameof(GetField), row, column);

        /// <summary>Gets the forward direction of the matrix.
        ///     <para />
        ///     ie. The first column of the matrix, excluding the w coordinate.
        /// </summary>
        /// <returns>The forward direction of the matrix.</returns>
        public Vector GetForward() => CallObject(nameof(GetForward)).ToVector();

        /// <summary>
        ///     Returns an inverted matrix without modifying the original matrix.
        ///     <para />
        ///     Inverting the matrix will fail if its <see cref="https://en.wikipedia.org/wiki/Determinant">determinant</see> is 0
        ///     or close to 0. (ie.its "scale" in any direction is 0.)
        ///     <para />
        ///     See also <seealso cref="GetInverseTR" />.
        /// </summary>
        /// <returns>The inverted matrix if possible (nil otherwise).</returns>
        public VMatrix GetInverse() => CallObject(nameof(GetInverse)).ToVMatrix();

        /// <summary>
        ///     Returns an inverted matrix without modifying the original matrix. This function will not fail, but only works
        ///     correctly on matrices that contain only translation and/or rotation.
        ///     <para />
        ///     Using this function on a matrix with modified scale may return an incorrect inverted matrix.
        ///     <para />
        ///     To get the inverse of a matrix that contains other modifications, see <seealso cref="GetInverse" />.
        /// </summary>
        /// <returns>The inverted matrix.</returns>
        public VMatrix GetInverseTR() => CallObject(nameof(GetInverseTR)).ToVMatrix();

        /// <summary>Gets the right direction of the matrix.
        ///     <para />
        ///     ie. The second column of the matrix, negated, excluding the w coordinate.
        /// </summary>
        /// <returns>The right direction of the matrix.</returns>
        public Vector GetRight() => CallObject(nameof(GetRight)).ToVector();

        /// <summary>Returns the absolute scale of the matrix.</summary>
        /// <returns>Absolute scale of the matrix.</returns>
        public Vector GetScale() => CallObject(nameof(GetScale)).ToVector();

        /// <summary>Returns the absolute translation of the matrix.</summary>
        /// <returns>Absolute translation of the matrix.</returns>
        public Vector GetTranslation() => CallObject(nameof(GetTranslation)).ToVector();

        /// <summary>Gets the up direction of the matrix.
        ///     <para />
        ///     ie. The third column of the matrix, excluding the w coordinate.
        /// </summary>
        /// <returns>The up direction of the matrix.</returns>
        public Vector GetUp() => CallObject(nameof(GetUp)).ToVector();

        /// <summary>Initializes the matrix as Identity matrix.</summary>
        public void Identity() => CallVoid(nameof(Identity));

        /// <summary>
        ///     Inverts the matrix.
        ///     <para />
        ///     Inverting the matrix will fail if its <see cref="https://en.wikipedia.org/wiki/Determinant">determinant</see> is 0
        ///     or close to 0. (ie.its "scale" in any direction is 0.)
        ///     <para />
        ///     If the matrix cannot be inverted, it does not get modified.
        ///     <para />
        ///     See also <seealso cref="InvertTR" />.
        /// </summary>
        /// <returns>Whether the matrix was inverted or not.</returns>
        public bool Invert() => CallBoolean(nameof(Invert));

        /// <summary>
        ///     Inverts the matrix. This function will not fail, but only works correctly on matrices that contain only
        ///     translation and/or rotation.
        ///     <para />
        ///     Using this function on a matrix with modified scale may return an incorrect inverted matrix.
        ///     <para />
        ///     To invert a matrix that contains other modifications, see <seealso cref="Invert" />.
        /// </summary>
        public void InvertTR() => CallVoid(nameof(InvertTR));

        /// <summary>Returns whether the matrix is equal to Identity matrix or not.</summary>
        /// <returns>Is the matrix an Identity matrix or not.</returns>
        public bool IsIdentity() => CallBoolean(nameof(IsIdentity));

        /// <summary>Returns whether the matrix is a rotation matrix or not.
        ///     <para />
        ///     Technically it checks if the forward, right and up vectors are orthogonal and normalized.
        /// </summary>
        /// <returns>Is the matrix a rotation matrix or not.</returns>
        public bool IsRotationMatrix() => CallBoolean(nameof(IsRotationMatrix));

        /// <summary>Rotates the matrix by the given angle.
        ///     <para />
        ///     Postmultiplies the matrix by a rotation matrix(A = AR).
        /// </summary>
        /// <param name="rotation">Rotation angle.</param>
        public void Rotate(Angle rotation) => CallVoid(nameof(Rotate), rotation);

        /// <summary>Scales the matrix by the given vector.
        ///     <para />
        ///     Postmultiplies the matrix by a scaling matrix(A = AS).
        /// </summary>
        /// <param name="scale">Vector to scale with matrix with.</param>
        public void Scale(Vector scale) => CallVoid(nameof(Scale), scale);

        /// <summary>Scales the absolute translation with the given value.</summary>
        /// <param name="scale">Value to scale the translation with.</param>
        public void ScaleTranslation(double scale) => CallVoid(nameof(ScaleTranslation), scale);

        /// <summary>Copies values from the given matrix object.</summary>
        /// <param name="sourceMatrix">The matrix to copy values from.</param>
        public void Set(VMatrix sourceMatrix) => CallVoid(nameof(Set), sourceMatrix);

        /// <summary>Sets the absolute rotation of the matrix.</summary>
        /// <param name="angle">New angles.</param>
        public void SetAngles(Angle angle) => CallVoid(nameof(SetAngles), angle);

        /// <summary>Sets a specific field in the matrix.</summary>
        /// <param name="row">Row of the field to be set, from 1 to 4.</param>
        /// <param name="column">Column of the field to be set, from 1 to 4.</param>
        /// <param name="value">The value to set in that field.</param>
        public void SetField(byte row, byte column, double value) => CallVoid(nameof(SetField), row, column, value);

        /// <summary>Sets the forward direction of the matrix.
        ///     <para />
        ///     ie. The first column of the matrix, excluding the w coordinate.
        /// </summary>
        /// <param name="forward">The forward direction of the matrix.</param>
        public void SetForward(Vector forward) => CallVoid(nameof(SetForward), forward);

        /// <summary>Sets the right direction of the matrix.
        ///     <para />
        ///     ie. The second column of the matrix, negated, excluding the w coordinate.
        /// </summary>
        /// <param name="forward">The right direction of the matrix.</param>
        public void SetRight(Vector forward) => CallVoid(nameof(SetRight), forward);

        /// <summary>Modifies the scale of the matrix while preserving the rotation and translation.</summary>
        /// <param name="scale">The scale to set.</param>
        public void SetScale(Vector scale) => CallVoid(nameof(SetScale), scale);

        /// <summary>Sets the absolute translation of the matrix.</summary>
        /// <param name="translation">New translation.</param>
        public void SetTranslation(Vector translation) => CallVoid(nameof(SetTranslation), translation);

        /// <summary>Sets the up direction of the matrix.
        ///     <para />
        ///     ie. The third column of the matrix, excluding the w coordinate.
        /// </summary>
        /// <param name="forward">The up direction of the matrix.</param>
        public void SetUp(Vector forward) => CallVoid(nameof(SetUp), forward);

        /// <summary>Converts the matrix to a 4x4 table. See <see cref="Global.Matrix" /> function.</summary>
        /// <returns>The 4x4 table.</returns>
        public LuaTable ToTable() => CallObject(nameof(ToTable)).ToTable();

        /// <summary>Translates the matrix by the given vector aka. adds the vector to the translation.
        ///     <para />
        ///     Postmultiplies the matrix by a translation matrix(A = AT).
        /// </summary>
        /// <param name="translation">Vector to translate the matrix by.</param>
        public void Translate(Vector translation) => CallVoid(nameof(Translate), translation);
    }
}