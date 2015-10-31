using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The utility library.</summary>
    static class util
    {
#if SERVER
        /// <summary>Adds the specified string to a string table, which will cache it and network it to all clients automatically.<para/>Whenever you want to create a net message with <see cref="net.Start"/>, you must add the name of that message as a networked string via this function.<para/>If the passed string already exists, nothing will happen and the ID of the existing item will be returned.<para/>NOTE: Due to the way string tables work, it's preferable to call this function as soon as the server starts up, such as in Initialize hook.<para/>The string table used for this function does not interfere with the engine string tables and has 2048 slots.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="networkString">The string to add to the table.</param>
        /// <returns>The ID of the string that was added to the string table.<para/>Same as calling <see cref="NetworkStringToID"/>.</returns>
        public static uint AddNetworkString(LuaState luaState, string networkString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(AddNetworkString));
                lua_pushstring(luaState, networkString);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tonumber(luaState);
            }
        }
#endif

        // TODO: util.AimVector (takes Angle structure as argument and returns a Vector structure).

        /// <summary>Encodes the specified string to base64.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="stringToEncode">String to encode.</param>
        /// <returns>Base 64 encoded string (or nil for a zero-length string).</returns>
        public static string Base64Encode(LuaState luaState, string stringToEncode)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(Base64Encode));
                lua_pushstring(luaState, stringToEncode);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        //#if SERVER
        // TODO: util.BlastDamage (takes Entity object and Vector structure as argument).

        // TODO: util.BlastDamageInfo (takes CTakeDamageInfo object and Vector structure as argument).
        //#endif

        /// <summary>Compresses the given string using <see cref="http://fastlz.org/">FastLZ</see>. Use with <see cref="net.WriteData"/> and <see cref="net.ReadData"/> for networking.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="stringToCompress">String to compress.</param>
        /// <returns>The compressed string (or nil for a zero-length string).</returns>
        public static string Compress(LuaState luaState, string stringToCompress)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(Compress));
                lua_pushstring(luaState, stringToCompress);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Generates the checksum of the specified string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="stringToHash">The string to calculate the checksum of.</param>
        /// <returns>The unsigned 32 bit checksum.</returns>
        public static string CRC(LuaState luaState, string stringToHash)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(CRC));
                lua_pushstring(luaState, stringToHash);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the current date formatted like '2015-10-27 20-04-59'.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>The current date formatted like '2015-10-27 20-04-59'.</returns>
        public static string DateStamp(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(DateStamp));
                lua_pcall(luaState, 0, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: util.Decal (takes Vector structure as argument).

        //#if CLIENT
        // TODO: util.DecalEx (takes IMaterial, Entity object, Vector structure and Color structure as argument).
        //#endif

        /// <summary>Gets the full material path by the decal name.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="decalName">Name of the decal.</param>
        /// <returns>The full material path by the decal name.</returns>
        public static string DecalMaterial(LuaState luaState, string decalName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(DecalMaterial));
                lua_pushstring(luaState, decalName);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Decompresses the given string using <see cref="http://fastlz.org/">FastLZ</see>.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="compressedString">String to decompress.</param>
        /// <returns>Uncompressed <paramref name="compressedString"/>.</returns>
        public static string Decompress(LuaState luaState, string compressedString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(Decompress));
                lua_pushstring(luaState, compressedString);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: util.DistanceToLine (takes Vector structure as argument).

        // TODO: util.Effect (takes CEffectData object and CRecipientFilter object as argument).

        // TODO: util.GetModelInfo (returns a table).

        /// <summary>Gets PData of an offline player using their Steam ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="steamId">Steam ID of the player.</param>
        /// <param name="name">Variable name to get the value of.</param>
        /// <param name="default">The default value, in case there's nothing stored.</param>
        /// <returns>The stored value.</returns>
        public static string GetPData(LuaState luaState, string steamId, string name, string @default)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(GetPData));
                lua_pushstring(luaState, steamId);
                lua_pushstring(luaState, name);
                lua_pushstring(luaState, @default);
                lua_pcall(luaState, 3, 1);
                return ToManagedString(luaState);
            }
        }

        //#if CLIENT
        // TODO: util.GetPixelVisibleHandle (returns pixelvis_handle_t structure).
        //#endif

        // TODO: util.GetPlayerTrace (takes Player object, Vector structure and returns a Trace structure).

        //#if CLIENT
        // TODO: util.GetSunInfo (returns a SunInfo structure).
        //#endif

        /// <summary>Returns the matching surface index for the surface name.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="surfaceName">The name of the surface.</param>
        /// <returns>The matching surface index for the <paramref name="surfaceName"/>.</returns>
        public static uint GetSurfaceIndex(LuaState luaState, string surfaceName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(GetSurfaceIndex));
                lua_pushstring(luaState, surfaceName);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        /// <summary>Returns a name of surfaceproperties ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="id">Surface properties ID. You can get it from <see cref="Structs.TraceResult"/> structure.</param>
        /// <returns>The name of surfaceproperties ID.</returns>
        public static string GetSurfacePropName(LuaState luaState, uint id)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(GetSurfacePropName));
                lua_pushnumber(luaState, id);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        //#if SERVER
        // TODO: util.GetUserGroups (returns a table).
        //#endif

        // TODO: util.IntersectRayWithOBB (takes Vector structure, Angle structure, and returns Vector structure).

        // TODO: util.IntersectRayWithPlane (takes and returns Vector structure).

        //#if SERVER
        // TODO: util.IsInWorld (takes a Vector structure).
        //#endif

        /// <summary>Checks if the model is loaded in the game.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="modelName">Name or path of the model to check.</param>
        /// <returns>True if the model is loaded in the game; otherwise false.</returns>
        public static bool IsModelLoaded(LuaState luaState, string modelName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(IsModelLoaded));
                lua_pushstring(luaState, modelName);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        //#if CLIENT
        // TODO: util.IsSkyboxVisibleFromPoint (takes a Vector structure as argument).
        //#endif

        /// <summary>Checks if the specified model is valid.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="modelName">Name or path of the model to check.</param>
        /// <returns>True if the specified model is valid; otherwise false.</returns>
        public static bool IsValidModel(LuaState luaState, string modelName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(IsValidModel));
                lua_pushstring(luaState, modelName);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        // TODO: util.IsValidPhysicsObject (takes Entity object as argument).

        /// <summary>Checks if the specified prop is valid.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="modelName">Name or path of the model to check.</param>
        /// <returns>True if the specified prop is valid; otherwise false.</returns>
        public static bool IsValidProp(LuaState luaState, string modelName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(IsValidProp));
                lua_pushstring(luaState, modelName);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        /// <summary>Checks if the specified model name points to a valid ragdoll.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="ragdollName">Name or path of the model to check.</param>
        /// <returns>True if the specified model name points to a valid ragdoll; otherwise false.</returns>
        public static bool IsValidRagdoll(LuaState luaState, string ragdollName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(IsValidRagdoll));
                lua_pushstring(luaState, ragdollName);
                lua_pcall(luaState, 1, 1);
                return lua_toboolean(luaState) == 1;
            }
        }

        // TODO: util.JSONToTable (returns a table).

        // TODO: util.KeyValuesToTable (returns a table).

        // TODO: util.KeyValuesToTablePreserveOrder (returns a table).

        // TODO: util.LocalToWorld (takes Entity object and returns Vector structure).

        /// <summary>Returns the networked string associated with the given ID from the string table.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="stringTableId">ID to get the associated string from.</param>
        /// <returns>The networked string (or nil if it wasn't found).</returns>
        public static string NetworkIDToString(LuaState luaState, uint stringTableId)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(NetworkIDToString));
                lua_pushnumber(luaState, stringTableId);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Returns the networked ID associated with the given string from the string table.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="networkString">String to get the associated networked ID from.</param>
        /// <returns>The networked ID of the string, or 0 if it hasn't been networked with <see cref="AddNetworkString"/>.</returns>
        public static uint NetworkStringToID(LuaState luaState, string networkString)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(NetworkStringToID));
                lua_pushstring(luaState, networkString);
                lua_pcall(luaState, 1, 1);
                return (uint)lua_tonumber(luaState);
            }
        }

        /// <summary>Formats a float by stripping off extra zeros and dots.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="float">The float to format.</param>
        /// <returns>Formatted <paramref name="float"/>.</returns>
        public static string NiceFloat(LuaState luaState, double @float)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(NiceFloat));
                lua_pushnumber(luaState, @float);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        // TODO: util.ParticleTracer (takes Vector structure as argument).

        // TODO: util.ParticleTracerEx (takes Vector structure as argument).

        //#if CLIENT
        // TODO: util.PixelVisible (takes Vector structure and pixelvis_handle_t structure as argument).
        //#endif

        // TODO: util.PointContents (takes a Vector structure as argument).

        /// <summary>Precaches a model for later use. Model is cached after being loaded once.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="modelName">The model to precache.</param>
        public static void PrecacheModel(LuaState luaState, string modelName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(PrecacheModel));
                lua_pushstring(luaState, modelName);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Precaches a sound for later use. Sound is cached after being loaded once.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="soundName">The sound to precache.</param>
        public static void PrecacheSound(LuaState luaState, string soundName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(PrecacheSound));
                lua_pushstring(luaState, soundName);
                lua_pcall(luaState, 1);
            }
        }

        // TODO: util.QuickTrace (takes Vector structure, [table or array of] Entity object[s], and returns a TraceResult structure).

        /// <summary>Returns the absolute system path to the file relative to /garrysmod/ folder.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="file">The file to get the absolute path of.</param>
        /// <returns>The absolute system path to <paramref name="file"/> relative to /garrysmod/ folder.</returns>
        public static string RelativePathToFull(LuaState luaState, string file)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(RelativePathToFull));
                lua_pushstring(luaState, file);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Removes PData of an offline player using their Steam ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="steamId">Steam ID of the player.</param>
        /// <param name="name">Variable name to remove.</param>
        public static void RemovePData(LuaState luaState, string steamId, string name)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(RemovePData));
                lua_pushstring(luaState, steamId);
                lua_pushstring(luaState, name);
                lua_pcall(luaState, 2);
            }
        }

        // TODO: util.ScreenShake (takes Vector structure as argument).

        /// <summary>Sets PData for an offline player using their Steam ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="steamId">Steam ID of the player.</param>
        /// <param name="name">Variable name to store the value in.</param>
        /// <param name="value">The value to store.</param>
        public static void SetPData(LuaState luaState, string steamId, string name, object value)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(SetPData));
                lua_pushstring(luaState, steamId);
                lua_pushstring(luaState, name);
                lua_pushobject(luaState, value);
                lua_pcall(luaState, 3);
            }
        }

        /// <summary>Generates a random float value that should be the same on client and server.<para/>NOTE: This function is best used in a <see cref="http://wiki.garrysmod.com/page/Category:Predicted_Hooks">predicted hook</see>.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="uniqueName">The seed for the random value.</param>
        /// <param name="min">The minimum value of the random range.</param>
        /// <param name="max">The maximum value of the random range.</param>
        /// <param name="additionalSeed">The additional seed.</param>
        /// <returns>The random float value.</returns>
        public static double SharedRandom(LuaState luaState, string uniqueName, double min, double max, double additionalSeed = 0.0D)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(SharedRandom));
                lua_pushstring(luaState, uniqueName);
                lua_pushnumber(luaState, min);
                lua_pushnumber(luaState, max);
                lua_pushnumber(luaState, additionalSeed);
                lua_pcall(luaState, 4, 1);
                return lua_tonumber(luaState);
            }
        }

        //#if SERVER
        // TODO: util.SpriteTrail (takes Entity object, Color structure and returns Entity object).
        //#endif

        // TODO: util.Stack (returns Stack object).

        /// <summary>Given a 64bit Steam ID will return a STEAM_0 style Steam ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="steam64Id">The 64 bit Steam ID.</param>
        /// <returns>STEAM_0 style Steam ID.</returns>
        public static string SteamIDFrom64(LuaState luaState, string steam64Id)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(SteamIDFrom64));
                lua_pushstring(luaState, steam64Id);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /// <summary>Given a STEAM_0 style Steam ID will return a 64bit Steam ID.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="steamId">The STEAM_0 style ID.</param>
        /// <returns>64bit Steam ID.</returns>
        public static string SteamIDTo64(LuaState luaState, string steamId)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(SteamIDTo64));
                lua_pushstring(luaState, steamId);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }

        /*
        /// <summary>Converts a string to the specified type.<para/>This can be useful when dealing with ConVars.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="input">The string to convert.</param>
        /// <param name="typeName">The type to attempt to convert the string to. This can be vector, angle, float, int, bool, or string (case insensitive).</param>
        /// <returns>The result of the conversion, or nil if a bad type is specified.</returns>
        public static object StringToType(LuaState luaState, string input, string typeName)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(StringToType));
                lua_pushstring(luaState, input);
                lua_pushstring(luaState, typeName);
                lua_pcall(luaState, 2, 1);
                // TODO: Function to cast to and handle any type.
            }
        }
        */

        // TODO: util.TableToJSON (takes table as argument).

        // TODO: util.TableToKeyValues (takes table as argument).

        // TODO: util.Timer (returns a Timer object).

        /// <summary>Returns the time since this function has been last called in milliseconds.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Time since this function has been last called in milliseconds.</returns>
        public static double TimerCycle(LuaState luaState)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(TimerCycle));
                lua_pcall(luaState, 0, 1);
                return lua_tonumber(luaState);
            }
        }

        // TODO: util.TraceEntity (takes Trace structure, Entity object and returns a TraceResult structure).

        // TODO: util.TraceHull (takes HullTrace structure and returns a TraceResult structure).

        // TODO: util.TraceLine (takes Trace structure and returns a TraceResult structure).

        /// <summary>Converts a type to a (nice, but still parsable) string.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="input">What to convert.</param>
        /// <returns>Converted string.</returns>
        public static string TypeToString(LuaState luaState, object input)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(util));
                lua_getfield(luaState, -1, nameof(TypeToString));
                lua_pushobject(luaState, input);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }
    }
}