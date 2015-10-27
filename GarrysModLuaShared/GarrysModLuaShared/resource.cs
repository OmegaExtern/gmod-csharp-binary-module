#if SERVER
using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The resource library is used to control what files are sent to clients who join a server, this includes models, materials, sounds, text files but not Lua files.</summary>
    static class resource
    {
        /// <summary>Adds the specified and all related files to the files the client should download.<para/>For convenience, this function will automatically add any other files that are related to the selected one, and throw an error if it can't find them. For example, a .vmt file will automatically add the .vtf with the same name, and a .mdl file will automatically add all .vvd, .ani, .dx80.vtx, .dx90.vtx, .sw.vtx, .phy and .jpg files with the same name, with a separate error for each missing file. If you do not want it to do this, use <see cref="AddSingleFile"/>.<para/>NOTE: There's a 8192 downloadable file limit. If you need more, consider using Workshop addons - <see cref="AddWorkshop"/>. You should also consider the fact that you have way too many downloads.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="path">Path of the file to be added, relative to garrysmod root folder.</param>
        public static void AddFile(IntPtr luaState, string path)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(resource));
                lua_getfield(luaState, -1, nameof(AddFile));
                lua_pushstring(luaState, path);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Adds the specified file to the files the client should download.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="path">Path of the file to be added, relative to garrysmod root folder.</param>
        public static void AddSingleFile(IntPtr luaState, string path)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(resource));
                lua_getfield(luaState, -1, nameof(AddSingleFile));
                lua_pushstring(luaState, path);
                lua_pcall(luaState, 1);
            }
        }

        /// <summary>Adds a workshop addon for the client to download before entering the server.<para/>Having the raw files from a workshop item does not count as having already downloaded it.<para/>So players who previously downloaded a map through Fast Download will have to re-download it if you use the workshop.<para/>You should try to only add addons that have custom content ( models, sounds, etc ).<para/>Gamemodes that are <see cref="http://wiki.garrysmod.com/page/Gamemode_Creation#Gamemode_Text_File">workshop enabled</see> are automatically added to this list - so there's no need to add them.<para/>The server's current map is also automatically added, if it is loaded from a workshop addon.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="workshopId">The workshop ID of the file. This cannot be a collection.</param>
        public static void AddWorkshop(IntPtr luaState, string workshopId)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(resource));
                lua_getfield(luaState, -1, nameof(AddWorkshop));
                lua_pushstring(luaState, workshopId);
                lua_pcall(luaState, 1);
            }
        }
    }
}
#endif