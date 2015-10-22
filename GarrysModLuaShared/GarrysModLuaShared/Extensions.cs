using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    static class Extensions
    {
        public static void luaL_addlstring(this luaL_Buffer buffer, string s, IntPtr l) => Lua.luaL_addlstring(buffer, s, l);

        public static void luaL_addstring(this luaL_Buffer buffer, string s) => Lua.luaL_addstring(buffer, s);

        public static void luaL_addvalue(this luaL_Buffer buffer) => Lua.luaL_addvalue(buffer);

        public static int luaL_argerror(this IntPtr luaState, int nargs, string extramsg) => Lua.luaL_argerror(luaState, nargs, extramsg);

        public static void luaL_buffinit(this IntPtr luaState, luaL_Buffer buffer) => Lua.luaL_buffinit(luaState, buffer);

        public static int luaL_callmeta(this IntPtr luaState, int obj, string e) => Lua.luaL_callmeta(luaState, obj, e);

        public static void luaL_checkany(this IntPtr luaState, int narg) => Lua.luaL_checkany(luaState, narg);

        public static int luaL_checkinteger(this IntPtr luaState, int narg) => Lua.luaL_checkinteger(luaState, narg);

        public static IntPtr luaL_checklstring(this IntPtr luaState, int narg, IntPtr l) => Lua.luaL_checklstring(luaState, narg, l);

        public static double luaL_checknumber(this IntPtr luaState, int narg) => Lua.luaL_checknumber(luaState, narg);

        public static int luaL_checkoption(this IntPtr luaState, int narg, string def, string[] lst) => Lua.luaL_checkoption(luaState, narg, def, lst);

        public static void luaL_checktype(this IntPtr luaState, int narg, int t) => Lua.luaL_checktype(luaState, narg, t);

        public static unsafe void* luaL_checkudata(this IntPtr luaState, int narg, string tname) => Lua.luaL_checkudata(luaState, narg, tname);

        public static int luaL_error(this IntPtr luaState, string fmt, params object[] args) => Lua.luaL_error(luaState, fmt, args);

        public static int luaL_execresult(this IntPtr luaState, int stat) => Lua.luaL_execresult(luaState, stat);

        public static int luaL_fileresult(this IntPtr luaState, int stat, string fname) => Lua.luaL_fileresult(luaState, stat, fname);

        public static string luaL_findtable(this IntPtr luaState, int idx, string fname, int szhint) => Lua.luaL_findtable(luaState, idx, fname, szhint);

        public static int luaL_getmetafield(this IntPtr luaState, int obj, string @event) => Lua.luaL_getmetafield(luaState, obj, @event);

        public static string luaL_gsub(this IntPtr luaState, string s, string p, string r) => Lua.luaL_gsub(luaState, s, p, r);

        public static int luaL_loadbuffer(this IntPtr luaState, string buff, IntPtr size, string name) => Lua.luaL_loadbuffer(luaState, buff, size, name);

        public static int luaL_loadbufferx(this IntPtr luaState, string buff, IntPtr size, string name, string mode) => Lua.luaL_loadbufferx(luaState, buff, size, name, mode);

        public static int luaL_loadfile(this IntPtr luaState, string filename) => Lua.luaL_loadfile(luaState, filename);

        public static int luaL_loadfilex(this IntPtr luaState, string filename, string mode) => Lua.luaL_loadfilex(luaState, filename, mode);

        public static int luaL_loadstring(this IntPtr luaState, string s) => Lua.luaL_loadstring(luaState, s);

        public static int luaL_newmetatable(this IntPtr luaState, string tname) => Lua.luaL_newmetatable(luaState, tname);

        public static int luaL_newmetatable_type(this IntPtr luaState, string tname, int tnum) => Lua.luaL_newmetatable_type(luaState, tname, tnum);

        public static void luaL_openlib(this IntPtr luaState, string libname, luaL_Reg[] l, int nup) => Lua.luaL_openlib(luaState, libname, l, nup);

        public static void luaL_openlibs(this IntPtr luaState) => Lua.luaL_openlibs(luaState);

        public static int luaL_optinteger(this IntPtr luaState, int arg, int def) => Lua.luaL_optinteger(luaState, arg, def);

        public static string luaL_optlstring(this IntPtr luaState, int arg, string def, IntPtr len) => Lua.luaL_optlstring(luaState, arg, def, len);

        public static double luaL_optnumber(this IntPtr luaState, int arg, double def) => Lua.luaL_optnumber(luaState, arg, def);

        public static char[] luaL_prepbuffer(this luaL_Buffer buffer) => Lua.luaL_prepbuffer(buffer);

        public static void luaL_pushresult(this luaL_Buffer buffer) => Lua.luaL_pushresult(buffer);

        public static int luaL_ref(this IntPtr luaState, int t) => Lua.luaL_ref(luaState, t);

        public static void luaL_register(this IntPtr luaState, string libname, luaL_Reg[] l) => Lua.luaL_register(luaState, libname, l);

        public static void luaL_traceback(this IntPtr luaState, IntPtr luaState1, string msg, int level) => Lua.luaL_traceback(luaState, luaState1, msg, level);

        public static int luaL_typerror(this IntPtr luaState, int narg, string tname) => Lua.luaL_typerror(luaState, narg, tname);

        public static void luaL_unref(this IntPtr luaState, int t, int @ref) => Lua.luaL_unref(luaState, t, @ref);

        public static void luaL_where(this IntPtr luaState, int level) => Lua.luaL_where(luaState, level);

        public static int luaopen_base(this IntPtr luaState) => Lua.luaopen_base(luaState);

        public static int luaopen_bit(this IntPtr luaState) => Lua.luaopen_bit(luaState);

        public static int luaopen_debug(this IntPtr luaState) => Lua.luaopen_debug(luaState);

        public static int luaopen_jit(this IntPtr luaState) => Lua.luaopen_jit(luaState);

        public static int luaopen_math(this IntPtr luaState) => Lua.luaopen_math(luaState);

        public static int luaopen_os(this IntPtr luaState) => Lua.luaopen_os(luaState);

        public static int luaopen_package(this IntPtr luaState) => Lua.luaopen_package(luaState);

        public static int luaopen_string(this IntPtr luaState) => Lua.luaopen_string(luaState);

        public static int luaopen_table(this IntPtr luaState) => Lua.luaopen_table(luaState);

        public static lua_CFunction lua_atpanic(this IntPtr luaState, lua_CFunction panicf) => Lua.lua_atpanic(luaState, panicf);

        public static void lua_call(this IntPtr luaState, int nargs, int nresults) => Lua.lua_call(luaState, nargs, nresults);

        public static int lua_checkstack(this IntPtr luaState, int extra) => Lua.lua_checkstack(luaState, extra);

        public static void lua_close(this IntPtr luaState) => Lua.lua_close(luaState);

        public static void lua_concat(this IntPtr luaState, int n) => Lua.lua_concat(luaState, n);

        public static unsafe int lua_cpcall(this IntPtr luaState, lua_CFunction func, void* ud) => Lua.lua_cpcall(luaState, func, ud);

        public static void lua_createtable(this IntPtr luaState, int narr, int nrec) => Lua.lua_createtable(luaState, narr, nrec);

        public static unsafe int lua_dump(this IntPtr luaState, lua_Writer writer, void* data) => Lua.lua_dump(luaState, writer, data);

        public static int lua_equal(this IntPtr luaState, int index1, int index2) => Lua.lua_equal(luaState, index1, index2);

        public static int lua_error(this IntPtr luaState) => Lua.lua_error(luaState);

        public static int lua_gc(this IntPtr luaState, int what, int data) => Lua.lua_gc(luaState, what, data);

        public static unsafe lua_Alloc lua_getallocf(this IntPtr luaState, void** ud) => Lua.lua_getallocf(luaState, ud);

        public static void lua_getfenv(this IntPtr luaState, int index) => Lua.lua_getfenv(luaState, index);

        public static void lua_getfield(this IntPtr luaState, int index, string k) => Lua.lua_getfield(luaState, index, k);

        public static lua_Hook lua_gethook(this IntPtr luaState) => Lua.lua_gethook(luaState);

        public static int lua_gethookcount(this IntPtr luaState) => Lua.lua_gethookcount(luaState);

        public static int lua_gethookmask(this IntPtr luaState) => Lua.lua_gethookmask(luaState);

        public static int lua_getinfo(this IntPtr luaState, string what, lua_Debug ar) => Lua.lua_getinfo(luaState, what, ar);

        public static string lua_getlocal(this IntPtr luaState, lua_Debug ar, int n) => Lua.lua_getlocal(luaState, ar, n);

        public static int lua_getmetatable(this IntPtr luaState, int index) => Lua.lua_getmetatable(luaState, index);

        public static int lua_getstack(this IntPtr luaState, int level, lua_Debug ar) => Lua.lua_getstack(luaState, level, ar);

        public static void lua_gettable(this IntPtr luaState, int index) => Lua.lua_gettable(luaState, index);

        public static int lua_gettop(this IntPtr luaState) => Lua.lua_gettop(luaState);

        public static string lua_getupvalue(this IntPtr luaState, int funcindex, int n) => Lua.lua_getupvalue(luaState, funcindex, n);

        public static void lua_insert(this IntPtr luaState, int index) => Lua.lua_insert(luaState, index);

        public static int lua_iscfunction(this IntPtr luaState, int index) => Lua.lua_iscfunction(luaState, index);

        public static int lua_isnumber(this IntPtr luaState, int index) => Lua.lua_isnumber(luaState, index);

        public static int lua_isstring(this IntPtr luaState, int index) => Lua.lua_isstring(luaState, index);

        public static int lua_isuserdata(this IntPtr luaState, int index) => Lua.lua_isuserdata(luaState, index);

        public static int lua_lessthan(this IntPtr luaState, int index1, int index2) => Lua.lua_lessthan(luaState, index1, index2);

        public static unsafe int lua_load(this IntPtr luaState, lua_Reader reader, void* data, string chunkname) => Lua.lua_load(luaState, reader, data, chunkname);

        public static unsafe int lua_loadx(this IntPtr luaState, lua_Reader reader, void* dt, string chunkname, string mode) => Lua.lua_loadx(luaState, reader, dt, chunkname, mode);

        public static unsafe IntPtr lua_newstate(this lua_Alloc f, void* ud) => Lua.lua_newstate(f, ud);

        public static IntPtr lua_newthread(this IntPtr luaState) => Lua.lua_newthread(luaState);

        public static unsafe void* lua_newuserdata(this IntPtr luaState, IntPtr size) => Lua.lua_newuserdata(luaState, size);

        public static int lua_next(this IntPtr luaState, int index) => Lua.lua_next(luaState, index);

        public static IntPtr lua_objlen(this IntPtr luaState, int index) => Lua.lua_objlen(luaState, index);

        public static int lua_pcall(this IntPtr luaState, int nargs, int nresults, int msgh) => Lua.lua_pcall(luaState, nargs, nresults, msgh);

        public static void lua_pushboolean(this IntPtr luaState, int b) => Lua.lua_pushboolean(luaState, b);

        public static void lua_pushcclosure(this IntPtr luaState, lua_CFunction fn, int n) => Lua.lua_pushcclosure(luaState, fn, n);

        public static string lua_pushfstring(this IntPtr luaState, string fmt, params object[] args) => Lua.lua_pushfstring(luaState, fmt, args);

        public static void lua_pushinteger(this IntPtr luaState, int n) => Lua.lua_pushinteger(luaState, n);

        public static unsafe void lua_pushlightuserdata(this IntPtr luaState, void* p) => Lua.lua_pushlightuserdata(luaState, p);

        public static void lua_pushlstring(this IntPtr luaState, string s, IntPtr len) => Lua.lua_pushlstring(luaState, s, len);

        public static void lua_pushnil(this IntPtr luaState) => Lua.lua_pushnil(luaState);

        public static void lua_pushnumber(this IntPtr luaState, double n) => Lua.lua_pushnumber(luaState, n);

        public static void lua_pushstring(this IntPtr luaState, [MarshalAs(UnmanagedType.LPStr)] string s) => Lua.lua_pushstring(luaState, s);

        public static int lua_pushthread(this IntPtr luaState) => Lua.lua_pushthread(luaState);

        public static void lua_pushvalue(this IntPtr luaState, int index) => Lua.lua_pushvalue(luaState, index);

        public static string lua_pushvfstring(this IntPtr luaState, string fmt, ArgIterator argp) => Lua.lua_pushvfstring(luaState, fmt, argp);

        public static int lua_rawequal(this IntPtr luaState, int index1, int index2) => Lua.lua_rawequal(luaState, index1, index2);

        public static void lua_rawget(this IntPtr luaState, int index) => Lua.lua_rawget(luaState, index);

        public static void lua_rawgeti(this IntPtr luaState, int index, int n) => Lua.lua_rawgeti(luaState, index, n);

        public static void lua_rawset(this IntPtr luaState, int index) => Lua.lua_rawset(luaState, index);

        public static void lua_rawseti(this IntPtr luaState, int index, int n) => Lua.lua_rawseti(luaState, index, n);

        public static void lua_remove(this IntPtr luaState, int index) => Lua.lua_remove(luaState, index);

        public static void lua_replace(this IntPtr luaState, int index) => Lua.lua_replace(luaState, index);

        public static void lua_resume_real(this IntPtr luaState, int narg) => Lua.lua_resume_real(luaState, narg);

        public static unsafe void lua_setallocf(this IntPtr luaState, lua_Alloc f, void* ud) => Lua.lua_setallocf(luaState, f, ud);

        public static int lua_setfenv(this IntPtr luaState, int index) => Lua.lua_setfenv(luaState, index);

        public static void lua_setfield(this IntPtr luaState, int index, string k) => Lua.lua_setfield(luaState, index, k);

        public static int lua_sethook(this IntPtr luaState, lua_Hook f, int mask, int count) => Lua.lua_sethook(luaState, f, mask, count);

        public static string lua_setlocal(this IntPtr luaState, lua_Debug ar, int n) => Lua.lua_setlocal(luaState, ar, n);

        public static int lua_setmetatable(this IntPtr luaState, int index) => Lua.lua_setmetatable(luaState, index);

        public static void lua_settable(this IntPtr luaState, int index) => Lua.lua_settable(luaState, index);

        public static void lua_settop(this IntPtr luaState, int index) => Lua.lua_settop(luaState, index);

        public static string lua_setupvalue(this IntPtr luaState, int funcindex, int n) => Lua.lua_setupvalue(luaState, funcindex, n);

        public static int lua_status(this IntPtr luaState) => Lua.lua_status(luaState);

        public static int lua_toboolean(this IntPtr luaState, int index) => Lua.lua_toboolean(luaState, index);

        public static lua_CFunction lua_tocfunction(this IntPtr luaState, int index) => Lua.lua_tocfunction(luaState, index);

        public static int lua_tointeger(this IntPtr luaState, int index) => Lua.lua_tointeger(luaState, index);

        public static IntPtr lua_tolstring(this IntPtr luaState, int index, IntPtr len) => Lua.lua_tolstring(luaState, index, len);

        public static IntPtr lua_tostring(this IntPtr luaState, int index) => Lua.lua_tostring(luaState, index);

        public static double lua_tonumber(this IntPtr luaState, int index) => Lua.lua_tonumber(luaState, index);

        public static unsafe void* lua_topointer(this IntPtr luaState, int index) => Lua.lua_topointer(luaState, index);

        public static IntPtr lua_tothread(this IntPtr luaState, int index) => Lua.lua_tothread(luaState, index);

        public static unsafe void* lua_touserdata(this IntPtr luaState, int index) => Lua.lua_touserdata(luaState, index);

        public static int lua_type(this IntPtr luaState, int index) => Lua.lua_type(luaState, index);

        public static string lua_typename(this IntPtr luaState, int tp) => Lua.lua_typename(luaState, tp);

        public static unsafe void* lua_upvalueid(this IntPtr luaState, int funcindex, int n) => Lua.lua_upvalueid(luaState, funcindex, n);

        public static void lua_upvaluejoin(this IntPtr luaState, int funcindex1, int n1, int funcindex2, int n2) => Lua.lua_upvaluejoin(luaState, funcindex1, n1, funcindex2, n2);

        public static void lua_xmove(this IntPtr from, IntPtr to, int n) => Lua.lua_xmove(from, to, n);

        public static int lua_yield(this IntPtr luaState, int nresults) => Lua.lua_yield(luaState, nresults);

        public static bool IsType(this IntPtr luaState, int index, Type type) => Lua.IsType(luaState, index, type);

        public static void Pop(this IntPtr luaState, int num = 1) => Lua.Pop(luaState, num);

        public static void Push(this IntPtr luaState, object value) => Lua.Push(luaState, value);

        public static string CheckManagedString(this IntPtr luaState, int index) => Lua.CheckManagedString(luaState, index);

        public static string ToManagedString(this IntPtr luaState, int index) => Lua.ToManagedString(luaState, index);

        public static void RegisterCFunction(this IntPtr luaState, string tableName, string funcName, lua_CFunction function) => Lua.RegisterCFunction(luaState, tableName, funcName, function);
    }
}