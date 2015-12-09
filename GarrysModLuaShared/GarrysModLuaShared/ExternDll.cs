namespace GarrysModLuaShared
{
    static class ExternDll
    {
        internal const string LuaShared = "lua_shared.dll";
#if SOURCE_SDK
        internal const string Kernel32 = "kernel32.dll";
        internal const string SourceExports = "source_exports.dll";
#endif
    }
}