#if CLIENT
using System;
using GarrysModLuaShared.Enums;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>
    ///     The input library allows you to gather information about the clients input devices (mouse & keyboard), such as
    ///     the cursor position and whether a key is pressed or not.
    /// </summary>
    static class input
    {
        /// <summary>Returns the last key captured by key trapping.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The key.</returns>
        public static KEY CheckKeyTrapping(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(CheckKeyTrapping));
                lua_pcall(luaState, 0, 1);
                return (KEY)(int)lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the cursor's position on the screen.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>First result is mouse X coordinate. Second result is mouse Y coordinate.</returns>
        public static Tuple<double, double> GetCursorPos(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(GetCursorPos));
                lua_pcall(luaState, 0, 2);
                return new Tuple<double, double>(lua_tonumber(luaState), lua_tonumber(luaState, -2));
            }
        }

        /// <summary>Returns the cursor's position on the screen.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="mouseX">Mouse X coordinate.</param>
        /// <param name="mouseY">Mouse Y coordinate.</param>
        public static void GetCursorPos(LuaState luaState, out double mouseX, out double mouseY)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(GetCursorPos));
                lua_pcall(luaState, 0, 2);
                mouseX = lua_tonumber(luaState);
                mouseY = lua_tonumber(luaState, -2);
            }
        }

        /// <summary>Gets the name of the button index.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="button">The button.</param>
        /// <returns>Button name.</returns>
        public static string GetKeyName(LuaState luaState, BUTTON button)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(GetKeyName));
                lua_pushnumber(luaState, (double)button);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Gets whether the specified button code is down.
        ///     <para />
        ///     Unlike <see cref="input.IsKeyDown" /> this can also detect joystick presses from <see cref="JOYSTICK" /> enum.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="button">The button, valid values are in the range of <see cref="BUTTON" /> enum.</param>
        /// <returns>Is the button down?</returns>
        public static bool IsButtonDown(LuaState luaState, BUTTON button)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(IsButtonDown));
                lua_pushnumber(luaState, (double)button);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns whether a control key is being pressed.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Is CTRL key down or not?</returns>
        public static bool IsControlDown(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(IsControlDown));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Gets whether a key is down.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        /// <returns>Is the key down?</returns>
        public static bool IsKeyDown(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(IsKeyDown));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns whether key trapping is activate and the next key press will be captured.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whether key trapping active or not.</returns>
        public static bool IsKeyTrapping(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(IsKeyTrapping));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Gets whether a mouse button is down.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="mouseKey">The mouse key.</param>
        /// <returns>Is the mouse key down?</returns>
        public static bool IsMouseDown(LuaState luaState, MOUSE mouseKey)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(IsMouseDown));
                lua_pushnumber(luaState, (double)mouseKey);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Gets whether a shift key is being pressed.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Is shift key down or not?</returns>
        public static bool IsShiftDown(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(IsShiftDown));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Gets the match uppercase key for the specified binding.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="binding">The binding name.</param>
        /// <param name="exact">True if the binding should match exactly.</param>
        /// <returns>The first key found with that binding.</returns>
        public static string LookupBinding(LuaState luaState, string binding, bool exact = false)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(LookupBinding));
                lua_pushstring(luaState, binding);
                lua_pushboolean(luaState, exact);
                lua_pcall(luaState, 2, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the bind string that the given key is bound to.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        /// <returns>The bind string of the given key.</returns>
        public static string LookupKeyBinding(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(LookupKeyBinding));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Sets the cursor's position on the screen, relative to the topleft corner of the window.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="mouseX">X coordinate for mouse position.</param>
        /// <param name="mouseY">Y coordinate for mouse position.</param>
        public static void SetCursorPos(LuaState luaState, double mouseX, double mouseY)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(SetCursorPos));
                lua_pushnumber(luaState, mouseX);
                lua_pushnumber(luaState, mouseY);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Starts key trap.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void StartKeyTrapping(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(StartKeyTrapping));
                lua_pcall(luaState);
            }
        }

        /// <summary>
        ///     Returns whether a key was initially pressed in the same frame this function was called.
        ///     <para />
        ///     This function only works in Move hooks, and will detect key presses even in main menu or when a typing in a text
        ///     field.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        /// <returns>Returns true if the key was initially pressed the same frame that this function was called; otherwise false.</returns>
        public static bool WasKeyPressed(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(WasKeyPressed));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>
        ///     Returns whether a key was released in the same frame this function was called.
        ///     <para />
        ///     This function only works in Move hooks, and will detect key releases even in main menu or when a typing in a text
        ///     field.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        /// <returns>Returns true if the key was initially released the same frame that this function was called; otherwise false.</returns>
        public static bool WasKeyReleased(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(WasKeyReleased));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>
        ///     Returns whether the key is being held down or not.
        ///     <para />
        ///     This function only works in Move hooks, and will detect key events even in main menu or when a typing in a text
        ///     field.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        /// <returns>Whether the key is being held down or not.</returns>
        public static bool WasKeyTyped(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(WasKeyTyped));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>
        ///     Returns whether a mouse key was double pressed in the same frame this function was called.
        ///     <para />
        ///     If this function returns true, <see cref="WasMousePressed" /> will return false.
        ///     <para />
        ///     This function only works in Move hooks, and will detect mouse events even in main menu or when a typing in a text
        ///     field.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="button">The mouse button to test.</param>
        /// <returns>Whether the mouse key was double pressed or not.</returns>
        public static bool WasMouseDoublePressed(LuaState luaState, MOUSE button)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(WasMouseDoublePressed));
                lua_pushnumber(luaState, (double)button);
                lua_pcall(luaState, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>
        ///     Returns whether a mouse key was initially pressed in the same frame this function was called.
        ///     <para />
        ///     If <see cref="WasMouseDoublePressed" /> returns true, this function will return false.
        ///     <para />
        ///     This function only works in Move hooks, and will detect mouse events even in main menu or when a typing in a text
        ///     field.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="button">The mouse button to test.</param>
        /// <returns>
        ///     Returns true if the mouse key was initially pressed the same frame that this function was called; otherwise
        ///     false.
        /// </returns>
        public static bool WasMousePressed(LuaState luaState, MOUSE button)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(input));
                lua_getfield(luaState, -1, nameof(WasMousePressed));
                lua_pushnumber(luaState, (double)button);
                lua_pcall(luaState, 1);
                return lua_toboolean(luaState) == 1;
            }
        }
    }
}

#endif