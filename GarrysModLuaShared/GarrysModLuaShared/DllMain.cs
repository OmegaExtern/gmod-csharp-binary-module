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
            RegisterCFunction(luaState, nameof(Process).ToLowerInvariant(), nameof(Process.Start), Process.Start);
            return 0;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_close(IntPtr luaState) => 0;
    }
}