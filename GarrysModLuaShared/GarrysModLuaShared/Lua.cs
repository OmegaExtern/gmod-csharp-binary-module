using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    static class Lua
    {
        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_addlstring(luaL_Buffer buffer, string s, IntPtr l);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_addstring(luaL_Buffer buffer, string s);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_addvalue(luaL_Buffer buffer);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_argerror(IntPtr luaState, int narg, string extramsg);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_buffinit(IntPtr luaState, luaL_Buffer buffer);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_callmeta(IntPtr luaState, int obj, string e);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_checkany(IntPtr luaState, int narg);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_checkinteger(IntPtr luaState, int narg);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr luaL_checklstring(IntPtr luaState, int narg, IntPtr l);

        [DllImport(ExternDll.LuaShared)]
        public static extern double luaL_checknumber(IntPtr luaState, int narg);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_checkoption(IntPtr luaState, int narg, string def, string[] lst);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_checktype(IntPtr luaState, int narg, int t);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void* luaL_checkudata(IntPtr luaState, int narg, string tname);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_error(IntPtr luaState, string fmt, params object[] args);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_execresult(IntPtr luaState, int stat);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_fileresult(IntPtr luaState, int stat, string fname);

        [DllImport(ExternDll.LuaShared)]
        public static extern string luaL_findtable(IntPtr luaState, int idx, string fname, int szhint);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_getmetafield(IntPtr luaState, int obj, string @event);

        [DllImport(ExternDll.LuaShared)]
        public static extern string luaL_gsub(IntPtr luaState, string s, string p, string r);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_loadbuffer(IntPtr luaState, string buff, IntPtr size, string name);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_loadbufferx(IntPtr luaState, string buff, IntPtr size, string name, string mode);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_loadfile(IntPtr luaState, string filename);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_loadfilex(IntPtr luaState, string filename, string mode);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_loadstring(IntPtr luaState, string s);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_newmetatable(IntPtr luaState, string tname);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_newmetatable_type(IntPtr luaState, string tname, int tnum);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr luaL_newstate();

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_openlib(IntPtr luaState, string libname, luaL_Reg[] l, int nup);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_openlibs(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_optinteger(IntPtr luaState, int arg, int def);

        [DllImport(ExternDll.LuaShared)]
        public static extern string luaL_optlstring(IntPtr luaState, int arg, string def, IntPtr len);

        [DllImport(ExternDll.LuaShared)]
        public static extern double luaL_optnumber(IntPtr luaState, int arg, double def);

        [DllImport(ExternDll.LuaShared)]
        public static extern char[] luaL_prepbuffer(luaL_Buffer buffer);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_pushresult(luaL_Buffer buffer);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_ref(IntPtr luaState, int t);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_register(IntPtr luaState, string libname, luaL_Reg[] l);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_traceback(IntPtr luaState, IntPtr luaState1, string msg, int level);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaL_typerror(IntPtr luaState, int narg, string tname);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_unref(IntPtr luaState, int t, int @ref);

        [DllImport(ExternDll.LuaShared)]
        public static extern void luaL_where(IntPtr luaState, int level);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_base(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_bit(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_debug(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_jit(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_math(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_os(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_package(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_string(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int luaopen_table(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern lua_CFunction lua_atpanic(IntPtr luaState, lua_CFunction panicf);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_call(IntPtr luaState, int nargs, int nresults);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_checkstack(IntPtr luaState, int extra);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_close(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_concat(IntPtr luaState, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe int lua_cpcall(IntPtr luaState, lua_CFunction func, void* ud);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_createtable(IntPtr luaState, int narr, int nrec);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe int lua_dump(IntPtr luaState, lua_Writer writer, void* data);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_equal(IntPtr luaState, int index1, int index2);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_error(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_gc(IntPtr luaState, int what, int data);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe lua_Alloc lua_getallocf(IntPtr luaState, void** ud);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_getfenv(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_getfield(IntPtr luaState, int index, string k);

        [DllImport(ExternDll.LuaShared)]
        public static extern lua_Hook lua_gethook(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_gethookcount(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_gethookmask(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_getinfo(IntPtr luaState, string what, lua_Debug ar);

        [DllImport(ExternDll.LuaShared)]
        public static extern string lua_getlocal(IntPtr luaState, lua_Debug ar, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_getmetatable(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_getstack(IntPtr luaState, int level, lua_Debug ar);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_gettable(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_gettop(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern string lua_getupvalue(IntPtr luaState, int funcindex, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_insert(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_iscfunction(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_isnumber(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_isstring(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_isuserdata(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_lessthan(IntPtr luaState, int index1, int index2);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe int lua_load(IntPtr luaState, lua_Reader reader, void* data, string chunkname);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe int lua_loadx(IntPtr luaState, lua_Reader reader, void* dt, string chunkname, string mode);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe IntPtr lua_newstate(lua_Alloc f, void* ud);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_newthread(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void* lua_newuserdata(IntPtr luaState, IntPtr size);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_next(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_objlen(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_pcall(IntPtr luaState, int nargs, int nresults, int msgh);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushboolean(IntPtr luaState, int b);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushcclosure(IntPtr luaState, lua_CFunction fn, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern string lua_pushfstring(IntPtr luaState, string fmt, params object[] args);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushinteger(IntPtr luaState, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void lua_pushlightuserdata(IntPtr luaState, void* p);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushlstring(IntPtr luaState, string s, IntPtr len);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushnil(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushnumber(IntPtr luaState, double n);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushstring(IntPtr luaState, [MarshalAs(UnmanagedType.LPStr)] string s);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_pushthread(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushvalue(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern string lua_pushvfstring(IntPtr luaState, string fmt, ArgIterator argp);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_rawequal(IntPtr luaState, int index1, int index2);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_rawget(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_rawgeti(IntPtr luaState, int index, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_rawset(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_rawseti(IntPtr luaState, int index, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_remove(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_replace(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_resume_real(IntPtr luaState, int narg);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void lua_setallocf(IntPtr luaState, lua_Alloc f, void* ud);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_setfenv(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_setfield(IntPtr luaState, int index, string k);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_sethook(IntPtr luaState, lua_Hook f, int mask, int count);

        [DllImport(ExternDll.LuaShared)]
        public static extern string lua_setlocal(IntPtr luaState, lua_Debug ar, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_setmetatable(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_settable(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_settop(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern string lua_setupvalue(IntPtr luaState, int funcindex, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_status(IntPtr luaState);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_toboolean(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern lua_CFunction lua_tocfunction(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_tointeger(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_tolstring(IntPtr luaState, int index, IntPtr len);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_tostring(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern double lua_tonumber(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void* lua_topointer(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_tothread(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void* lua_touserdata(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_type(IntPtr luaState, int index);

        [DllImport(ExternDll.LuaShared)]
        public static extern string lua_typename(IntPtr luaState, int tp);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void* lua_upvalueid(IntPtr luaState, int funcindex, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_upvaluejoin(IntPtr luaState, int funcindex1, int n1, int funcindex2, int n2);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_xmove(IntPtr from, IntPtr to, int n);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_yield(IntPtr luaState, int nresults);

        public static bool IsType(IntPtr luaState, int index, Type type) => lua_type(luaState, index) == (int)type;

        public static void Pop(IntPtr luaState, int num = 1) => lua_settop(luaState, -(num) - 1);

        public static void Push(IntPtr luaState, object value)
        {
            if (value == null)
            {
                lua_pushnil(luaState);
                return;
            }
            if (value is bool)
            {
                lua_pushboolean(luaState, (bool)value ? 1 : 0);
                return;
            }
            if (value is int)
            {
                lua_pushinteger(luaState, (int)value);
                return;
            }
            if (value is float)
            {
                lua_pushnumber(luaState, (float)value);
                return;
            }
            if (value is double)
            {
                lua_pushnumber(luaState, (double)value);
                return;
            }
            if (value is string)
            {
                lua_pushstring(luaState, value.ToString());
                return;
            }
            lua_CFunction function = value as lua_CFunction;
            if (function != null)
            {
                lua_pushcclosure(luaState, function, 0);
            }
        }

        public static string CheckManagedString(IntPtr luaState, int index) => Marshal.PtrToStringAnsi(luaL_checklstring(luaState, index, IntPtr.Zero));

        public static string ToManagedString(IntPtr luaState, int index) => Marshal.PtrToStringAnsi(lua_tolstring(luaState, index, IntPtr.Zero));

        public static void RegisterCFunction(IntPtr luaState, string tableName, string funcName, lua_CFunction function)
        {
            lua_getfield(luaState, (int)TableIndex.SpecialGlob, tableName);
            if (!IsType(luaState, -1, Type.Table))
            {
                lua_createtable(luaState, 0, 1);
                lua_setfield(luaState, (int)TableIndex.SpecialGlob, tableName);
                Pop(luaState);
                lua_getfield(luaState, (int)TableIndex.SpecialGlob, tableName);
            }
            lua_pushstring(luaState, funcName);
            lua_pushcclosure(luaState, function, 0);
            lua_settable(luaState, -3);
            Pop(luaState);
        }
    }
}