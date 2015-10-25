using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using static GarrysModLuaShared.Lua;

namespace GarrysModLuaShared
{
    static class Process
    {
        public static int Start(IntPtr luaState)
        {
            int nargs = lua_gettop(luaState);
            if (nargs < 1 || nargs > 3)
            {
                return 0;
            }
            string fileName = CheckManagedString(luaState, 1);
            try
            {
                System.Diagnostics.Process process;
                if (nargs == 1)
                {
                    process = System.Diagnostics.Process.Start(fileName);
                }
                else
                {
                    string arguments = CheckManagedString(luaState, 2);
                    process = System.Diagnostics.Process.Start(fileName, arguments);
                    if (nargs == 3)
                    {
                        luaL_checktype(luaState, 3, (int)Type.Bool);
                        if (lua_toboolean(luaState, 3) == 1)
                        {
                            new Thread(() => process?.WaitForExit()).Start();
                        }
                    }
                }
                if (process == null)
                {
                    return 0;
                }
                lua_pushnumber(luaState, process.Id);
                lua_pushstring(luaState, process.ProcessName);
                lua_pushstring(luaState, process.MainModule.FileName);
                return 3;
            }
            catch (Win32Exception)
            {
                return 0;
            }
            catch (FileNotFoundException)
            {
                return 0;
            }
            catch (ObjectDisposedException)
            {
                return 0;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
            catch (SystemException)
            {
                return 0;
            }
        }
    }
}