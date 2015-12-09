#if CLIENT
using System;
using GarrysModLuaShared.Enums;
using GarrysModLuaShared.Properties;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>
    ///     The gui library is similar to the <see cref="input" /> library but features functions that are more focused on
    ///     the mouse's interaction with GUI panels.
    /// </summary>
    static class gui
    {
        /// <summary>Opens the game menu overlay.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void ActivateGameUI(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(ActivateGameUI));
                lua_pcall(luaState);
            }
        }

        /// <summary>Enables the mouse cursor without restricting player movement, like using Sandbox's Context Menu.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="enabled">Whether the cursor should be enabled or not (true = enable, false = disable).</param>
        public static void EnableScreenClicker(LuaState luaState, bool enabled)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(EnableScreenClicker));
                lua_pushboolean(luaState, enabled);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Hides the game menu overlay.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        public static void HideGameUI(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(HideGameUI));
                lua_pcall(luaState);
            }
        }

        /// <summary>Simulates a mouse move with the given deltas.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="deltaX">The movement delta on the x axis.</param>
        /// <param name="deltaY">The movement delta on the y axis.</param>
        public static void InternalCursorMoved(LuaState luaState, double deltaX, double deltaY)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalCursorMoved));
                lua_pushnumber(luaState, deltaX);
                lua_pushnumber(luaState, deltaY);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Simulates a key press for the given key.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        public static void InternalKeyCodePressed(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalKeyCodePressed));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Simulates a key release for the given key.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        public static void InternalKeyCodeReleased(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalKeyCodeReleased));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Simulates a key type typing to the specified key.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        public static void InternalKeyCodeTyped(LuaState luaState, KEY key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalKeyCodeTyped));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Simulates a ASCII symbol writing. Use for write text in chat or VGUI. Don't work while console open!</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="code">ASCII code of symbol, see <see cref="Resources.ASCII_table" />.</param>
        public static void InternalKeyTyped(LuaState luaState, double code)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalKeyTyped));
                lua_pushnumber(luaState, code);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Simulates a double mouse key press for the given mouse key.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        public static void InternalMouseDoublePressed(LuaState luaState, MOUSE key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalMouseDoublePressed));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Simulates a mouse key press for the given mouse key.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        public static void InternalMousePressed(LuaState luaState, MOUSE key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalMousePressed));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Simulates a mouse key release for the given mouse key.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="key">The key.</param>
        public static void InternalMouseReleased(LuaState luaState, MOUSE key)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalMouseReleased));
                lua_pushnumber(luaState, (double)key);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Simulates a mouse wheel scroll with the given delta.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="delta">The amount of scrolling to simulate.</param>
        public static void InternalMouseWheeled(LuaState luaState, double delta)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(InternalMouseWheeled));
                lua_pushnumber(luaState, delta);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Returns whenever the console is visible.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Is console visible?</returns>
        public static bool IsConsoleVisible(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(IsConsoleVisible));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns whenever the game menu overlay ( main menu ) is open or not.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Whenever the game menu overlay ( main menu ) is open or not</returns>
        public static bool IsGameUIVisible(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(IsGameUIVisible));
                lua_pcall(luaState, 0, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Returns the cursor's position on the screen.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>First result is mouse X coordinate. Second result is mouse Y coordinate.</returns>
        public static Tuple<double, double> MousePos(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(MousePos));
                lua_pcall(luaState, 0, 2);
                return new Tuple<double, double>(lua_tonumber(luaState), lua_tonumber(luaState, -2));
            }
        }

        /// <summary>Returns the cursor's position on the screen.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="mouseX">Mouse X coordinate.</param>
        /// <param name="mouseY">Mouse Y coordinate.</param>
        public static void MousePos(LuaState luaState, out double mouseX, out double mouseY)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(MousePos));
                lua_pcall(luaState, 0, 2);
                mouseX = lua_tonumber(luaState);
                mouseY = lua_tonumber(luaState, -2);
            }
        }

        /// <summary>Returns X component of the mouse position.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Mouse X coordinate.</returns>
        public static double MouseX(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(MouseX));
                lua_pcall(luaState);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Returns Y component of the mouse position.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Mouse Y coordinate.</returns>
        public static double MouseY(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(MouseY));
                lua_pcall(luaState);
                return lua_tonumber(luaState);
            }
        }

        /// <summary>Opens specified URL in the steam overlay browser. The URL has to start with either "http://" or "https://".</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="url">URL to open.</param>
        public static void OpenURL(LuaState luaState, string url)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(OpenURL));
                lua_pushstring(luaState, url);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: gui.ScreenToVector (returns a Vector type).

        /// <summary>Sets the cursor's position on the screen, relative to the topleft corner of the window.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="mouseX">The X coordinate to move the cursor to.</param>
        /// <param name="mouseY">The Y coordinate to move the cursor to.</param>
        public static void SetMousePos(LuaState luaState, double mouseX, double mouseY)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(gui));
                lua_getfield(luaState, -1, nameof(SetMousePos));
                lua_pushnumber(luaState, mouseX);
                lua_pushnumber(luaState, mouseY);
                lua_pcall(luaState, 2);
            }
        }
    }
}

#endif