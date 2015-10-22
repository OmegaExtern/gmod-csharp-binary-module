using System;
using System.IO;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    static class ExternalFile
    {
        public static int Delete(IntPtr luaState)
        {
            int nargs = lua_gettop(luaState);
            if (nargs < 1 || nargs > 2)
            {
                return 0;
            }
            try
            {
                string path = CheckManagedString(luaState, 1); // First argument should be of type string.
                if (!File.Exists(path) && !Directory.Exists(path))
                {
                    return 0;
                }
                FileAttributes attributes = File.GetAttributes(path);
                if (!attributes.HasFlag(FileAttributes.Directory))
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    return 0;
                }
                if (!Directory.Exists(path))
                {
                    return 0;
                }
                int recursive = default(int);
                if (nargs == 2)
                {
                    recursive = lua_toboolean(luaState, 2); // Second argument should be of type boolean (but is optional argument and only used for directories).
                }
                Directory.Delete(path, recursive == 1);
            }
            catch
            {
            }
            return 0;
        }

        public static int IsDir(IntPtr luaState)
        {
            if (lua_gettop(luaState) != 1)
            {
                return 0;
            }
            string path = CheckManagedString(luaState, 1); // First argument should be of type string.
            bool isDirectory;
            try
            {
                FileAttributes fileAttributes = File.GetAttributes(path);
                isDirectory = fileAttributes.HasFlag(FileAttributes.Directory);
            }
            catch
            {
                return 0;
            }
            lua_pushboolean(luaState, isDirectory ? 1 : 0);
            return 1;
        }

        public static int Read(IntPtr luaState)
        {
            if (lua_gettop(luaState) != 1)
            {
                return 0;
            }
            string path = CheckManagedString(luaState, 1); // First argument should be of type string.
            try
            {
                if (!File.Exists(path))
                {
                    return 0;
                }
                string contents = File.ReadAllText(path);
                lua_pushstring(luaState, contents);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int Write(IntPtr luaState)
        {
            if (lua_gettop(luaState) != 2)
            {
                return 0;
            }
            string path = CheckManagedString(luaState, 1); // First argument should be of type string.
            string contents = CheckManagedString(luaState, 2); // Second argument should be of type string.
            try
            {
                File.WriteAllText(path, contents);
            }
            catch
            {
            }
            return 0;
        }
    }
}