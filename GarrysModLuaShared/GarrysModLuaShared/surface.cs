#if CLIENT
using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>
    ///     The surface library allows you to draw text and shapes on the screen. Primarily used for making HUDs & custom
    ///     GUI panels.
    /// </summary>
    static class surface
    {
        // TODO: surface.CreateFont (takes table as argument).

        /// <summary>Enables or disables the clipping used by the VGUI that limits the drawing operations to a panels bounds.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="disable">True to disable, false to enable the clipping.</param>
        public static void DisableClipping(LuaState luaState, bool disable)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DisableClipping));
                lua_pushboolean(luaState, disable);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: surface.DrawCircle (takes Color structure as argument).

        /// <summary>Draws a line from one point to another.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="startX">The start X coordinate.</param>
        /// <param name="startY">The start Y coordinate.</param>
        /// <param name="endX">The end X coordinate.</param>
        /// <param name="endY">The end Y coordinate.</param>
        public static void DrawLine(LuaState luaState, uint startX, uint startY, uint endX, uint endY)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DrawLine));
                lua_pushnumber(luaState, startX);
                lua_pushnumber(luaState, startY);
                lua_pushnumber(luaState, endX);
                lua_pushnumber(luaState, endY);
                lua_pcall(luaState, 4);
            }
        }

        /// <summary>Draws a hollow box with a border width of 1 px.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The start X coordinate.</param>
        /// <param name="y">The start Y coordinate.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public static void DrawOutlinedRect(LuaState luaState, uint x, uint y, uint width, uint height)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DrawOutlinedRect));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, y);
                lua_pushnumber(luaState, width);
                lua_pushnumber(luaState, height);
                lua_pcall(luaState, 4);
            }
        }

        // TODO: surface.DrawPoly (takes PolygonVertex structure as argument).

        /// <summary>Draws a solid rectangle on the screen.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The X co-ordinate.</param>
        /// <param name="y">The Y co-ordinate.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public static void DrawRect(LuaState luaState, uint x, uint y, uint width, uint height)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DrawRect));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, y);
                lua_pushnumber(luaState, width);
                lua_pushnumber(luaState, height);
                lua_pcall(luaState, 4);
            }
        }

        /// <summary>Draw the specified text on the screen, using the previously set position, font and color.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="text">The text to be rendered.</param>
        public static void DrawText(LuaState luaState, string text)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DrawText));
                lua_pushstring(luaState, text);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>
        ///     Draw a textured rectangle with the given position and dimensions on the screen, using the current active
        ///     texture.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The X co-ordinate.</param>
        /// <param name="y">The Y co-ordinate.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public static void DrawTexturedRect(LuaState luaState, uint x, uint y, uint width, uint height)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DrawTexturedRect));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, y);
                lua_pushnumber(luaState, width);
                lua_pushnumber(luaState, height);
                lua_pcall(luaState, 4);
            }
        }

        /// <summary>
        ///     Draw a textured rotated rectangle with the given position and dimensions and angle on the screen, using the
        ///     current active texture.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The X co-ordinate, representing the center of the rectangle.</param>
        /// <param name="y">The Y co-ordinate, representing the center of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="rotation">The rotation of the rectangle, in degrees.</param>
        public static void DrawTexturedRectRotated(LuaState luaState, uint x, uint y, uint width, uint height, double rotation)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DrawTexturedRectRotated));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, y);
                lua_pushnumber(luaState, width);
                lua_pushnumber(luaState, height);
                lua_pushnumber(luaState, rotation);
                lua_pcall(luaState, 5);
            }
        }

        /// <summary>
        ///     Draws a textured rectangle with a repeated or partial texture. U and V refer to texture coordinates. 0,0 is
        ///     the bottom left corner of the texture, 1,0 is the bottom right, 1,1 is the top right and 0,1 is the top left.
        ///     <para />
        ///     If you are using a .png image, you must supply "noclamp" as second parameter for <see cref="Global.Material" />.
        ///     <para />
        ///     Using a start point of(1,0) and an end point to(0,1), you can draw an image flipped horizontally, etc with other
        ///     directions.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="startU">The U texture mapping of the rect origin.</param>
        /// <param name="startV">The V texture mapping of the rect origin.</param>
        /// <param name="endU">The U texture mapping of the rect end.</param>
        /// <param name="endV">The V texture mapping of the rect end.</param>
        public static void DrawTexturedRectUV(LuaState luaState, uint x, uint y, uint width, uint height, double startU, double startV, double endU, double endV)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(DrawTexturedRectUV));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, y);
                lua_pushnumber(luaState, width);
                lua_pushnumber(luaState, height);
                lua_pushnumber(luaState, startU);
                lua_pushnumber(luaState, startV);
                lua_pushnumber(luaState, endU);
                lua_pushnumber(luaState, endV);
                lua_pcall(luaState, 8);
            }
        }

        // TODO: surface.GetHUDTexture (returns ITexture object).

        /// <summary>
        ///     Returns the width and height (in pixels) of the given text, but only if the font has been set with
        ///     <see cref="SetFont" />.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="text">The string to check the size of.</param>
        /// <returns>
        ///     First result is width of <paramref name="text" /> in pixels. Second result is height of
        ///     <paramref name="text" /> in pixels.
        /// </returns>
        public static Tuple<int, int> GetTextSize(LuaState luaState, string text)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(GetTextSize));
                lua_pushstring(luaState, text);
                lua_pcall(luaState, 1, 2);
                return new Tuple<int, int>(lua_tointeger(luaState), lua_tointeger(luaState, -2));
            }
        }

        /// <summary>
        ///     Returns the width and height (in pixels) of the given text, but only if the font has been set with
        ///     <see cref="SetFont" />.
        /// </summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="text">The string to check the size of.</param>
        /// <param name="width">Width of <paramref name="text" /> in pixels.</param>
        /// <param name="height">Height of <paramref name="text" /> in pixels.</param>
        public static void GetTextSize(LuaState luaState, string text, out int width, out int height)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(GetTextSize));
                lua_pushstring(luaState, text);
                lua_pcall(luaState, 1, 2);
                width = lua_tointeger(luaState);
                height = lua_tointeger(luaState, -2);
            }
        }

        /// <summary>Returns the texture ID of the texture with the given name/path.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="nameOrPath">Name or path of the texture.</param>
        /// <returns>Texture ID of the texture with the given <paramref name="nameOrPath" />.</returns>
        public static uint GetTextureID(LuaState luaState, string nameOrPath)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(GetTextureID));
                lua_pushstring(luaState, nameOrPath);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        /// <summary>Returns the size of the texture with the associated texture ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="textureId">The texture ID.</param>
        /// <returns>First result is the width of texture. Second result is the height of texture.</returns>
        public static Tuple<int, int> GetTextureSize(LuaState luaState, uint textureId)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(GetTextureSize));
                lua_pushnumber(luaState, textureId);
                lua_pcall(luaState, 1, 2);
                return new Tuple<int, int>(lua_tointeger(luaState), lua_tointeger(luaState, -2));
            }
        }

        /// <summary>Returns the size of the texture with the associated texture ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="textureId">The texture ID.</param>
        /// <param name="width">The width of texture.</param>
        /// <param name="height">The height of texture.</param>
        public static void GetTextureSize(LuaState luaState, uint textureId, out int width, out int height)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(GetTextureSize));
                lua_pushnumber(luaState, textureId);
                lua_pcall(luaState, 1, 2);
                width = lua_tointeger(luaState);
                height = lua_tointeger(luaState, -2);
            }
        }

        /// <summary>Play a sound file directly on the client (such as UI sounds, etc).</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="soundFile">The path to the sound file.</param>
        public static void PlaySound(LuaState luaState, string soundFile)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(PlaySound));
                lua_pushstring(luaState, soundFile);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Sets a multiplier that will influence all upcoming drawing operations.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="multiplier">The multiplier ranging from 0 to 1.</param>
        public static void SetAlphaMultiplier(LuaState luaState, double multiplier)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(SetAlphaMultiplier));
                lua_pushnumber(luaState, multiplier);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Set the color of any future shapes to be drawn.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="r">The red value of color.</param>
        /// <param name="g">The green value of color.</param>
        /// <param name="b">The blue value of color.</param>
        /// <param name="a">The alpha value of color.</param>
        public static void SetDrawColor(LuaState luaState, byte r, byte g, byte b, byte a = byte.MaxValue) // TODO: Add Color structure overload after implementing tables.
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(SetDrawColor));
                lua_pushinteger(luaState, r);
                lua_pushinteger(luaState, g);
                lua_pushinteger(luaState, b);
                lua_pushinteger(luaState, a);
                lua_pcall(luaState, 4);
            }
        }

        /// <summary>Set the current font to be used for text operations later.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="fontName">The name of the font to use.</param>
        public static void SetFont(LuaState luaState, string fontName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(SetFont));
                lua_pushstring(luaState, fontName);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: surface.SetMaterial (takes IMaterial object as argument).

        /// <summary>Set the color of any future text to be drawn.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="r">The red value of color.</param>
        /// <param name="g">The green value of color.</param>
        /// <param name="b">The blue value of color.</param>
        /// <param name="a">The alpha value of color.</param>
        public static void SetTextColor(LuaState luaState, byte r, byte g, byte b, byte a = byte.MaxValue) // TODO: Add Color structure overload after implementing tables.
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(SetTextColor));
                lua_pushinteger(luaState, r);
                lua_pushinteger(luaState, g);
                lua_pushinteger(luaState, b);
                lua_pushinteger(luaState, a);
                lua_pcall(luaState, 4);
            }
        }

        /// <summary>Set the position to draw any future text.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="x">The X co-ordinate.</param>
        /// <param name="y">The Y co-ordinate.</param>
        public static void SetTextPos(LuaState luaState, uint x, uint y)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(SetTextPos));
                lua_pushnumber(luaState, x);
                lua_pushnumber(luaState, y);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Sets the texture to be used in all upcoming surface draw operations.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="textureId">The ID of the texture to draw with.</param>
        public static void SetTexture(LuaState luaState, uint textureId)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(surface));
                lua_getfield(luaState, -1, nameof(SetTexture));
                lua_pushnumber(luaState, textureId);
                lua_pcall(luaState, 1);
            }
        }
    }
}

#endif