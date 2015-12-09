//
// IMPORTANT NOTE /!!\
//   If you are developing a clientside (gmcl) binary module, go to properties of the project, click on "Build" tab and define "CLIENT" (without double-quotes, case-sensitive!) in "Conditional compilation symbols".
//   If you are developing a serverside (gmsv) binary module, then define "SERVER" (without double-quotes, case-sensitive!) in "Conditional compilation symbols".
//
// ADDITIONAL NOTES
//   If you want to call function from Source engine (work in progress), you can do so by defining "SOURCE_SDK" (without double-quotes, case-sensitive!) in "Conditional compilation symbols".
//   For those who defined SOURCE_SDK:
//     This "grants you an access" to GarrysModLuaShared.Source namespace.
//     There is one more step you have to do once you compile C# binary module and you want to try it out:
//       Copy "source_exports.dll" file to GarrysMod folder (in the folder where "hl2.exe" file is). Do not rename "source_exports.dll" file!
//       You can find "source_exports.dll" file in the output folder (in the same folder as C# binary module; bin/Release), you can also find it inside "Dependencies" folder of this project.
//
// WIKI: https://github.com/OmegaExtern/gmod-csharp-binary-module/wiki
//

using System;
using System.Runtime.InteropServices;
using GarrysModLuaShared.Classes;
#if SOURCE_SDK
using GarrysModLuaShared.Source;
#endif
using GarrysModLuaShared.Structs;
using RGiesecke.DllExport;
using static GarrysModLuaShared.Global;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    static class DllMain
    {
        /// <summary>Called when your module is opened.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Number of return values.</returns>
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_open(LuaState luaState)
        {
            InitializeLua(luaState);

            //
            // Do your stuff  -  below.
            //

            return 0;
        }

        /// <summary>Called when your module is closed.</summary>
        /// <param name="luaState">Pointer to lua_State struct.</param>
        /// <returns>Number of return values.</returns>
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_close(LuaState luaState) => 0;
    }
}