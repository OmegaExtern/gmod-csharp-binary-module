using GarrysModLuaShared.Enums;

namespace GarrysModLuaShared.Classes
{
    /// <summary>
    ///     A class used to store the player inputs, such as mouse movement, view angles, <see cref="IN" /> buttons
    ///     pressed and analog movement, the data from this class is then transfered to a <see cref="CMoveData" /> during
    ///     actual movement simulation.
    ///     <para />
    ///     Can be modified during CreateMove, StartCommand hook and used in read only with SetupMove hook and
    ///     <see cref="Player.GetCurrentCommand" />.
    /// </summary>
    public sealed class CUserCmd : LuaObject
    {
        static readonly int CUserCmdId = Random.Generator.Next((int)Type.UserCmd, int.MaxValue);

        public CUserCmd(int index) : base(index) { }

        /// <summary>Removes all keys from the command. Doesn't prevent movement, see <see cref="ClearMovement" /> for this.</summary>
        public void ClearButtons() => CallVoid(nameof(ClearButtons));

        /// <summary>Clears the movement from the command.</summary>
        public void ClearMovement() => CallVoid(nameof(ClearMovement));

        /// <summary>
        ///     Returns an increasing number representing the index of the user cmd. The value returned is occasionally 0
        ///     inside CreateMove hook, so it's advised to check for a non-zero value if you wish to get the correct number.
        /// </summary>
        /// <returns>The command number.</returns>
        public double CommandNumber() => CallNumber(nameof(CommandNumber));

        /// <summary>Returns a bitflag indicating which buttons are pressed.</summary>
        /// <returns>Pressed buttons.</returns>
        public IN GetButtons() => (IN)CallNumber(nameof(GetButtons));

        /// <summary>The speed the client wishes to move forward with, negative if the clients wants to move backwards.</summary>
        /// <returns>The desired speed.</returns>
        public double GetForwardMove() => CallNumber(nameof(GetForwardMove));

        /// <summary>Gets the current impulse from the client, usually 0.</summary>
        /// <returns>The impulse.</returns>
        public double GetImpulse() => CallNumber(nameof(GetImpulse));

        /// <summary>Returns the scroll delta as whole number.</summary>
        /// <returns>Scroll delta.</returns>
        public double GetMouseWheel() => CallNumber(nameof(GetMouseWheel));

        /// <summary>Returns the delta of the angular horizontal mouse movement of the player.</summary>
        /// <returns>Mouse X delta.</returns>
        public int GetMouseX() => CallInteger(nameof(GetMouseX));

        /// <summary>Returns the delta of the angular vertical mouse movement of the player.</summary>
        /// <returns>Mouse Y delta.</returns>
        public int GetMouseY() => CallInteger(nameof(GetMouseY));

        /// <summary>
        ///     The speed the client wishes to move sideways with, positive if it wants to move right, negative if it wants to
        ///     move left.
        /// </summary>
        /// <returns>Request speed.</returns>
        public double GetSideMove() => CallNumber(nameof(GetSideMove));

        /// <summary>The speed the client wishes to move up with, negative if the clients wants to move down.</summary>
        /// <returns>Request speed.</returns>
        public double GetUpMove() => CallNumber(nameof(GetUpMove));

        /// <summary>Gets the direction the client wants to move in.</summary>
        /// <returns>Request direction.</returns>
        public Angle GetViewAngles() => CallObject(nameof(GetViewAngles)).ToAngle();

        /// <summary>Returns true if the specified button(s) is pressed.</summary>
        /// <param name="key">Bitflag representing which button to check.</param>
        /// <returns>Is key down or not?</returns>
        public bool KeyDown(IN key) => CallBoolean(nameof(KeyDown), (int)key);

        /// <summary>Removed a key bit from the current key bitflag.</summary>
        /// <param name="button">Bitflag to be removed from the key bitflag.</param>
        public void RemoveKey(IN button) => CallVoid(nameof(RemoveKey), (int)button);

        /// <summary>
        ///     Forces the associated player to select a weapon.
        ///     <para />
        ///     This is used internally in the default HL2 weapon selection HUD.
        ///     <para />
        ///     NOTE: Due to a bug, you will have to force this function to run until <see cref="Player.GetActiveWeapon" /> returns
        ///     the chosen weapon, although it is also advised to add a time limit in case the switch fails for any reason.
        ///     <para />
        ///     NOTE 2: This is the ideal function to use to create a custom weapon selection HUD, as it allows prediction to run
        ///     properly for WEAPON.Deploy hook and PlayerSwitchWeapon hook.
        /// </summary>
        /// <param name="weapon">The weapon entity to select.</param>
        public void SelectWeapon(Weapon weapon) => CallVoid(nameof(SelectWeapon), weapon);

        /// <summary>Sets the buttons bitflag.</summary>
        /// <param name="buttons">Bitflag representing which buttons are "down".</param>
        public void SetButtons(IN buttons) => CallVoid(nameof(SetButtons), (int)buttons);

        /// <summary>Sets speed the client wishes to move forward with, negative if the clients wants to move backwards.</summary>
        /// <param name="speed">The new speed to request.</param>
        public void SetForwardMove(double speed) => CallVoid(nameof(SetForwardMove), speed);

        /// <summary>Sets the impulse to be send together with the command.</summary>
        /// <param name="impulse">The impulse to send.</param>
        public void SetImpulse(double impulse) => CallVoid(nameof(SetImpulse), impulse);

        /// <summary>Sets the scroll delta.</summary>
        /// <param name="delta">The scroll delta.</param>
        public void SetMouseWheel(double delta) => CallVoid(nameof(SetMouseWheel), delta);

        /// <summary>Sets the delta of the angular horizontal mouse movement of the player.</summary>
        /// <param name="x">Angular horizontal move delta.</param>
        public void SetMouseX(int x) => CallVoid(nameof(SetMouseX), x);

        /// <summary>Sets the delta of the angular vertical mouse movement of the player.</summary>
        /// <param name="y">Angular vertical move delta.</param>
        public void SetMouseY(int y) => CallVoid(nameof(SetMouseY), y);

        /// <summary>Sets speed the client wishes to move sidewards with, positive to move right, negative to move left.</summary>
        /// <param name="speed">The new speed to request.</param>
        public void SetSideMove(double speed) => CallVoid(nameof(SetSideMove), speed);

        /// <summary>Sets speed the client wishes to move upwards with, negative to move down.</summary>
        /// <param name="speed">The new speed to request.</param>
        public void SetUpMove(double speed) => CallVoid(nameof(SetUpMove), speed);

        /// <summary>Sets the direction the client wants to move in.</summary>
        /// <param name="viewAngle">New view angles.</param>
        public void SetViewAngles(Angle viewAngle) => CallVoid(nameof(SetViewAngles), viewAngle);

        /// <summary>Returns tick count since joining the server. Sometimes returns 0.</summary>
        /// <returns>The amount of ticks passed since joining the server.</returns>
        public double TickCount() => CallNumber(nameof(TickCount));
    }
}