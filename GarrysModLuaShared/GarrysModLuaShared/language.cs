#if CLIENT
using System;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    /// <summary>The language library is used for translation.</summary>
    static class language
    {
        /// <summary>Adds a language item. Language placeholders are replaced with full text in Garry's Mod once registered with this function.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="placeholder">The key for this phrase.</param>
        /// <param name="fullText">The phrase that should be displayed whenever this key is used.</param>
        public static void Add(IntPtr luaState, string placeholder, string fullText)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(language));
                lua_getfield(luaState, -1, nameof(Add));
                lua_pushstring(luaState, placeholder);
                lua_pushstring(luaState, fullText);
                lua_pcall(luaState, 2);
            }
        }

        /// <summary>Retrieves the translated version of inputted string. Useful for concentrating multiple translated strings.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <param name="phrase">The untranslated phrase.</param>
        /// <returns>The translated version of inputted <paramref name="phrase"/>.</returns>
        public static string GetPhrase(IntPtr luaState, string phrase)
        {
            lock (SyncRoot)
            {
                lua_getglobal(luaState, nameof(language));
                lua_getfield(luaState, -1, nameof(GetPhrase));
                lua_pushstring(luaState, phrase);
                lua_pcall(luaState, 1, 1);
                return ToManagedString(luaState);
            }
        }
    }
}
#endif