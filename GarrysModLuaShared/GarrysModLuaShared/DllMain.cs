using System;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    static class DllMain
    {
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_open(IntPtr luaState)
        {
            return 0;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_close(IntPtr luaState) => 0;
    }
}