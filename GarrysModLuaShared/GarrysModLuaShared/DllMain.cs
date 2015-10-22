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
            RegisterCFunction(luaState, nameof(ExternalFile).ToLowerInvariant(), nameof(ExternalFile.Delete), ExternalFile.Delete);
            RegisterCFunction(luaState, nameof(ExternalFile).ToLowerInvariant(), nameof(ExternalFile.IsDir), ExternalFile.IsDir);
            RegisterCFunction(luaState, nameof(ExternalFile).ToLowerInvariant(), nameof(ExternalFile.Read), ExternalFile.Read);
            RegisterCFunction(luaState, nameof(ExternalFile).ToLowerInvariant(), nameof(ExternalFile.Write), ExternalFile.Write);
            return 0;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static int gmod13_close(IntPtr luaState) => 0;
    }
}