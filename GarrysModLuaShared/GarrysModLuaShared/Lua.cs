using System;
using System.Runtime.InteropServices;

namespace GarrysModLuaShared
{
    static class Lua
    {
        static IntPtr _state = IntPtr.Zero;
        internal static readonly object SyncRoot = new object();

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

        public static void luaL_checktype(IntPtr luaState, int narg, Type type) => luaL_checktype(luaState, narg, (int)type);

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
        public static extern void lua_createtable(IntPtr luaState, int narr = 0, int nrec = 0);

        public static void lua_newtable(IntPtr luaState) => lua_createtable(luaState);

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

        public static void lua_getfield(IntPtr luaState, TableIndex index, string k) => lua_getfield(luaState, (int)index, k);

        public static void lua_getglobal(IntPtr luaState, string k) => lua_getfield(luaState, (int)TableIndex.SpecialGlob, k);

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
        public static extern int lua_pcall(IntPtr luaState, int nargs = 0, int nresults = 0, int msgh = 0);

        [DllImport(ExternDll.LuaShared)]
        public static extern void lua_pushboolean(IntPtr luaState, int b);

        public static void lua_pushboolean(IntPtr luaState, bool b) => lua_pushboolean(luaState, b ? 1 : 0);

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

        public static void lua_setglobal(IntPtr luaState, string k) => lua_setfield(luaState, (int)TableIndex.SpecialGlob, k);

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
        public static extern int lua_toboolean(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern lua_CFunction lua_tocfunction(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_tointeger(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_tolstring(IntPtr luaState, int index, IntPtr len);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_tostring(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern double lua_tonumber(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void* lua_topointer(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern IntPtr lua_tothread(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern unsafe void* lua_touserdata(IntPtr luaState, int index = -1);

        [DllImport(ExternDll.LuaShared)]
        public static extern int lua_type(IntPtr luaState, int index);

        public static bool lua_type(IntPtr luaState, int index, Type type) => lua_type(luaState, index) == (int)type;

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

        public static void lua_pop(IntPtr luaState, int num = 1) => lua_settop(luaState, -(num) - 1);

        public static void lua_pushobject(IntPtr luaState, object value)
        {
            if (value == null)
            {
                lua_pushnil(luaState);
                return;
            }
            if (value is bool)
            {
                lua_pushboolean(luaState, (bool)value);
                return;
            }
            if (value is sbyte)
            {
                lua_pushinteger(luaState, (sbyte)value);
                return;
            }
            if (value is byte)
            {
                lua_pushinteger(luaState, (byte)value);
                return;
            }
            if (value is short)
            {
                lua_pushinteger(luaState, (short)value);
                return;
            }
            if (value is ushort)
            {
                lua_pushinteger(luaState, (ushort)value);
                return;
            }
            if (value is int)
            {
                lua_pushinteger(luaState, (int)value);
                return;
            }
            if (value is uint)
            {
                lua_pushnumber(luaState, (uint)value);
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
            lua_CFunction f = value as lua_CFunction;
            if (f != null)
            {
                lua_pushcclosure(luaState, f, 0);
            }
            LuaObject o = value as LuaObject;
            if (o != null)
            {
                lua_pushvalue(o.GetIndex());
                return;
            }
            lua_pushnil(luaState); // Pushing nil for now. TODO: After implementing tables.
        }

        public static int UpvalueIndex(int index) => (int)TableIndex.SpecialGlob - index;

        public static int AbsIndex(IntPtr luaState, int index) => (index > 0 || index <= (int)TableIndex.SpecialReg) ? index : lua_gettop(luaState) + index + 1;

        public static string CheckManagedString(IntPtr luaState, int index) => Marshal.PtrToStringAnsi(luaL_checklstring(luaState, index, IntPtr.Zero));

        public static string ToManagedString(IntPtr luaState, int index = -1) => Marshal.PtrToStringAnsi(lua_tolstring(luaState, index, IntPtr.Zero));

        public static void RegisterCFunction(IntPtr luaState, string tableName, string funcName, lua_CFunction function)
        {
            lua_getfield(luaState, (int)TableIndex.SpecialGlob, tableName);
            if (!lua_type(luaState, -1, Type.Table))
            {
                lua_createtable(luaState, 0, 1);
                lua_setglobal(luaState, tableName);
                lua_pop(luaState);
                lua_getglobal(luaState, tableName);
            }
            lua_pushstring(luaState, funcName);
            lua_pushcclosure(luaState, function, 0);
            lua_settable(luaState, -3);
            lua_pop(luaState);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int luaL_argerror(int narg, string extramsg) => luaL_argerror(_state, narg, extramsg);

        public static void luaL_buffinit(luaL_Buffer buffer) => luaL_buffinit(_state, buffer);

        public static int luaL_callmeta(int obj, string e) => luaL_callmeta(_state, obj, e);

        public static void luaL_checkany(int narg) => luaL_checkany(_state, narg);

        public static int luaL_checkinteger(int narg) => luaL_checkinteger(_state, narg);

        public static IntPtr luaL_checklstring(int narg, IntPtr l) => luaL_checklstring(_state, narg, l);

        public static double luaL_checknumber(int narg) => luaL_checknumber(_state, narg);

        public static int luaL_checkoption(int narg, string def, string[] lst) => luaL_checkoption(_state, narg, def, lst);

        public static void luaL_checktype(int narg, int t) => luaL_checktype(_state, narg, t);

        public static void luaL_checktype(int narg, Type type) => luaL_checktype(_state, narg, type);

        public static unsafe void* luaL_checkudata(int narg, string tname) => luaL_checkudata(_state, narg, tname);

        public static int luaL_error(string fmt, params object[] args) => luaL_error(_state, fmt, args);

        public static int luaL_execresult(int stat) => luaL_execresult(_state, stat);

        public static int luaL_fileresult(int stat, string fname) => luaL_fileresult(_state, stat, fname);

        public static string luaL_findtable(int idx, string fname, int szhint) => luaL_findtable(_state, idx, fname, szhint);

        public static int luaL_getmetafield(int obj, string @event) => luaL_getmetafield(_state, obj, @event);

        public static string luaL_gsub(string s, string p, string r) => luaL_gsub(_state, s, p, r);

        public static int luaL_loadbuffer(string buff, IntPtr size, string name) => luaL_loadbuffer(_state, buff, size, name);

        public static int luaL_loadbufferx(string buff, IntPtr size, string name, string mode) => luaL_loadbufferx(_state, buff, size, name, mode);

        public static int luaL_loadfile(string filename) => luaL_loadfile(_state, filename);

        public static int luaL_loadfilex(string filename, string mode) => luaL_loadfilex(_state, filename, mode);

        public static int luaL_loadstring(string s) => luaL_loadstring(_state, s);

        public static int luaL_newmetatable(string tname) => luaL_newmetatable(_state, tname);

        public static int luaL_newmetatable_type(string tname, int tnum) => luaL_newmetatable_type(_state, tname, tnum);

        public static void luaL_openlib(string libname, luaL_Reg[] l, int nup) => luaL_openlib(_state, libname, l, nup);

        public static void luaL_openlibs() => luaL_openlibs(_state);

        public static int luaL_optinteger(int arg, int def) => luaL_optinteger(_state, arg, def);

        public static string luaL_optlstring(int arg, string def, IntPtr len) => luaL_optlstring(_state, arg, def, len);

        public static double luaL_optnumber(int arg, double def) => luaL_optnumber(_state, arg, def);

        public static int luaL_ref(int t) => luaL_ref(_state, t);

        public static void luaL_register(string libname, luaL_Reg[] l) => luaL_register(_state, libname, l);

        public static void luaL_traceback(IntPtr luaState1, string msg, int level) => luaL_traceback(_state, luaState1, msg, level);

        public static int luaL_typerror(int narg, string tname) => luaL_typerror(_state, narg, tname);

        public static void luaL_unref(int t, int @ref) => luaL_unref(_state, t, @ref);

        public static void luaL_where(int level) => luaL_where(_state, level);

        public static int luaopen_base() => luaopen_base(_state);

        public static int luaopen_bit() => luaopen_bit(_state);

        public static int luaopen_debug() => luaopen_debug(_state);

        public static int luaopen_jit() => luaopen_jit(_state);

        public static int luaopen_math() => luaopen_math(_state);

        public static int luaopen_os() => luaopen_os(_state);

        public static int luaopen_package() => luaopen_package(_state);

        public static int luaopen_string() => luaopen_string(_state);

        public static int luaopen_table() => luaopen_table(_state);

        public static lua_CFunction lua_atpanic(lua_CFunction panicf) => lua_atpanic(_state, panicf);

        public static void lua_call(int nargs, int nresults) => lua_call(_state, nargs, nresults);

        public static int lua_checkstack(int extra) => lua_checkstack(_state, extra);

        public static void lua_close() => lua_close(_state);

        public static void lua_concat(int n) => lua_concat(_state, n);

        public static unsafe int lua_cpcall(lua_CFunction func, void* ud) => lua_cpcall(_state, func, ud);

        public static void lua_createtable(int narr = 0, int nrec = 0) => lua_createtable(_state, narr, nrec);

        public static void lua_newtable() => lua_createtable(_state);

        public static unsafe int lua_dump(lua_Writer writer, void* data) => lua_dump(_state, writer, data);

        public static int lua_equal(int index1, int index2) => lua_equal(_state, index1, index2);

        public static int lua_error() => lua_error(_state);

        public static int lua_gc(int what, int data) => lua_gc(_state, what, data);

        public static unsafe lua_Alloc lua_getallocf(void** ud) => lua_getallocf(_state, ud);

        public static void lua_getfenv(int index) => lua_getfenv(_state, index);

        public static void lua_getfield(int index, string k) => lua_getfield(_state, index, k);

        public static void lua_getfield(TableIndex index, string k) => lua_getfield(_state, index, k);

        public static void lua_getglobal(string k) => lua_getglobal(_state, k);

        public static lua_Hook lua_gethook() => lua_gethook(_state);

        public static int lua_gethookcount() => lua_gethookcount(_state);

        public static int lua_gethookmask() => lua_gethookmask(_state);

        public static int lua_getinfo(string what, lua_Debug ar) => lua_getinfo(_state, what, ar);

        public static string lua_getlocal(lua_Debug ar, int n) => lua_getlocal(_state, ar, n);

        public static int lua_getmetatable(int index) => lua_getmetatable(_state, index);

        public static int lua_getstack(int level, lua_Debug ar) => lua_getstack(_state, level, ar);

        public static void lua_gettable(int index) => lua_gettable(_state, index);

        public static int lua_gettop() => lua_gettop(_state);

        public static string lua_getupvalue(int funcindex, int n) => lua_getupvalue(_state, funcindex, n);

        public static void lua_insert(int index) => lua_insert(_state, index);

        public static int lua_iscfunction(int index) => lua_iscfunction(_state, index);

        public static int lua_isnumber(int index) => lua_isnumber(_state, index);

        public static int lua_isstring(int index) => lua_isstring(_state, index);

        public static int lua_isuserdata(int index) => lua_isuserdata(_state, index);

        public static int lua_lessthan(int index1, int index2) => lua_lessthan(_state, index1, index2);

        public static unsafe int lua_load(lua_Reader reader, void* data, string chunkname) => lua_load(_state, reader, data, chunkname);

        public static unsafe int lua_loadx(lua_Reader reader, void* dt, string chunkname, string mode) => lua_loadx(_state, reader, dt, chunkname, mode);

        public static IntPtr lua_newthread() => lua_newthread(_state);

        public static unsafe void* lua_newuserdata(IntPtr size) => lua_newuserdata(_state, size);

        public static int lua_next(int index) => lua_next(_state, index);

        public static IntPtr lua_objlen(int index) => lua_objlen(_state, index);

        public static int lua_pcall(int nargs = 0, int nresults = 0, int msgh = 0) => lua_pcall(_state, nargs, nresults, msgh);

        public static void lua_pushboolean(int b) => lua_pushboolean(_state, b);

        public static void lua_pushboolean(bool b) => lua_pushboolean(_state, b);

        public static void lua_pushcclosure(lua_CFunction fn, int n) => lua_pushcclosure(_state, fn, n);

        public static string lua_pushfstring(string fmt, params object[] args) => lua_pushfstring(_state, fmt, args);

        public static void lua_pushinteger(int n) => lua_pushinteger(_state, n);

        public static unsafe void lua_pushlightuserdata(void* p) => lua_pushlightuserdata(_state, p);

        public static void lua_pushlstring(string s, IntPtr len) => lua_pushlstring(_state, s, len);

        public static void lua_pushnil() => lua_pushnil(_state);

        public static void lua_pushnumber(double n) => lua_pushnumber(_state, n);

        public static void lua_pushstring([MarshalAs(UnmanagedType.LPStr)] string s) => lua_pushstring(_state, s);

        public static int lua_pushthread() => lua_pushthread(_state);

        public static void lua_pushvalue(int index) => lua_pushvalue(_state, index);

        public static string lua_pushvfstring(string fmt, ArgIterator argp) => lua_pushvfstring(_state, fmt, argp);

        public static int lua_rawequal(int index1, int index2) => lua_rawequal(_state, index1, index2);

        public static void lua_rawget(int index) => lua_rawget(_state, index);

        public static void lua_rawgeti(int index, int n) => lua_rawgeti(_state, index, n);

        public static void lua_rawset(int index) => lua_rawset(_state, index);

        public static void lua_rawseti(int index, int n) => lua_rawseti(_state, index, n);

        public static void lua_remove(int index) => lua_remove(_state, index);

        public static void lua_replace(int index) => lua_replace(_state, index);

        public static void lua_resume_real(int narg) => lua_resume_real(_state, narg);

        public static unsafe void lua_setallocf(lua_Alloc f, void* ud) => lua_setallocf(_state, f, ud);

        public static int lua_setfenv(int index) => lua_setfenv(_state, index);

        public static void lua_setfield(int index, string k) => lua_setfield(_state, index, k);

        public static void lua_setglobal(string k) => lua_setglobal(_state, k);

        public static int lua_sethook(lua_Hook f, int mask, int count) => lua_sethook(_state, f, mask, count);

        public static string lua_setlocal(lua_Debug ar, int n) => lua_setlocal(_state, ar, n);

        public static int lua_setmetatable(int index) => lua_setmetatable(_state, index);

        public static void lua_settable(int index) => lua_settable(_state, index);

        public static void lua_settop(int index) => lua_settop(_state, index);

        public static string lua_setupvalue(int funcindex, int n) => lua_setupvalue(_state, funcindex, n);

        public static int lua_status() => lua_status(_state);

        public static int lua_toboolean(int index = -1) => lua_toboolean(_state, index);

        public static lua_CFunction lua_tocfunction(int index = -1) => lua_tocfunction(_state, index);

        public static int lua_tointeger(int index = -1) => lua_tointeger(_state, index);

        public static IntPtr lua_tolstring(int index, IntPtr len) => lua_tolstring(_state, index, len);

        public static IntPtr lua_tostring(int index = -1) => lua_tostring(_state, index);

        public static double lua_tonumber(int index = -1) => lua_tonumber(_state, index);

        public static unsafe void* lua_topointer(int index = -1) => lua_topointer(_state, index);

        public static IntPtr lua_tothread(int index = -1) => lua_tothread(_state, index);

        public static unsafe void* lua_touserdata(int index = -1) => lua_touserdata(_state, index);

        public static int lua_type(int index) => lua_type(_state, index);

        public static bool lua_type(int index, Type type) => lua_type(_state, index, type);

        public static string lua_typename(int tp) => lua_typename(_state, tp);

        public static unsafe void* lua_upvalueid(int funcindex, int n) => lua_upvalueid(_state, funcindex, n);

        public static void lua_upvaluejoin(int funcindex1, int n1, int funcindex2, int n2) => lua_upvaluejoin(_state, funcindex1, n1, funcindex2, n2);

        public static int lua_yield(int nresults) => lua_yield(_state, nresults);

        public static void lua_pop(int num = 1) => lua_pop(_state, num);

        public static void lua_pushobject(object value) => lua_pushobject(_state, value);

        public static int AbsIndex(int index) => AbsIndex(_state, index);

        public static string CheckManagedString(int index) => CheckManagedString(_state, index);

        public static string ToManagedString(int index = -1) => ToManagedString(_state, index);

        public static void RegisterCFunction(string tableName, string funcName, lua_CFunction function) => RegisterCFunction(_state, tableName, funcName, function);

        public static void Init(IntPtr luaState) => _state = luaState;
    }
}