//
// IMPORTANT NOTE /!!\
//   If you are developing a clientside (gmcl) binary module, go to properties of the project, click on "Build" tab and set "Conditional compilation symbols" to "CLIENT" (without double-quotes, case-sensitive!).
//   If you are developing a serverside (gmsv) binary module, then write "SERVER" (without double-quotes, case-sensitive!) in "Conditional compilation symbols" textbox.
//

using System;
using System.Runtime.InteropServices;
using GarrysModLuaShared.Classes;
using GarrysModLuaShared.Structs;
using RGiesecke.DllExport;
using static GarrysModLuaShared.Global;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    static class DllMain
    {
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_open(LuaState luaState)
        {
            Init(luaState);

            //
            // Do your stuff  -  below.
            //

            return 0;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_close(LuaState luaState) => 0;
    }
}