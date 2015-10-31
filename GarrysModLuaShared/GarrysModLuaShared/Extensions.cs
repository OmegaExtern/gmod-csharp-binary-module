using System;
using System.Runtime.InteropServices;
using GarrysModLuaShared.Classes;

namespace GarrysModLuaShared
{
    static class Extensions
    {
        public static void luaL_addlstring(this luaL_Buffer buffer, string s, IntPtr l) => Lua.luaL_addlstring(buffer, s, l);

        public static void luaL_addstring(this luaL_Buffer buffer, string s) => Lua.luaL_addstring(buffer, s);

        public static void luaL_addvalue(this luaL_Buffer buffer) => Lua.luaL_addvalue(buffer);

        public static int luaL_argerror(this LuaState luaState, int nargs, string extramsg) => Lua.luaL_argerror(luaState, nargs, extramsg);

        public static void luaL_buffinit(this LuaState luaState, luaL_Buffer buffer) => Lua.luaL_buffinit(luaState, buffer);

        public static int luaL_callmeta(this LuaState luaState, int obj, string e) => Lua.luaL_callmeta(luaState, obj, e);

        public static void luaL_checkany(this LuaState luaState, int narg) => Lua.luaL_checkany(luaState, narg);

        public static int luaL_checkinteger(this LuaState luaState, int narg) => Lua.luaL_checkinteger(luaState, narg);

        public static IntPtr luaL_checklstring(this LuaState luaState, int narg, IntPtr l) => Lua.luaL_checklstring(luaState, narg, l);

        public static double luaL_checknumber(this LuaState luaState, int narg) => Lua.luaL_checknumber(luaState, narg);

        public static int luaL_checkoption(this LuaState luaState, int narg, string def, string[] lst) => Lua.luaL_checkoption(luaState, narg, def, lst);

        public static void luaL_checktype(this LuaState luaState, int narg, int t) => Lua.luaL_checktype(luaState, narg, t);

        public static void luaL_checktype(this LuaState luaState, int narg, Type type) => Lua.luaL_checktype(luaState, narg, type);

        public static unsafe void* luaL_checkudata(this LuaState luaState, int narg, string tname) => Lua.luaL_checkudata(luaState, narg, tname);

        public static int luaL_error(this LuaState luaState, string fmt, params object[] args) => Lua.luaL_error(luaState, fmt, args);

        public static int luaL_execresult(this LuaState luaState, int stat) => Lua.luaL_execresult(luaState, stat);

        public static int luaL_fileresult(this LuaState luaState, int stat, string fname) => Lua.luaL_fileresult(luaState, stat, fname);

        public static string luaL_findtable(this LuaState luaState, int idx, string fname, int szhint) => Lua.luaL_findtable(luaState, idx, fname, szhint);

        public static int luaL_getmetafield(this LuaState luaState, int obj, string @event) => Lua.luaL_getmetafield(luaState, obj, @event);

        public static string luaL_gsub(this LuaState luaState, string s, string p, string r) => Lua.luaL_gsub(luaState, s, p, r);

        public static int luaL_loadbuffer(this LuaState luaState, string buff, IntPtr size, string name) => Lua.luaL_loadbuffer(luaState, buff, size, name);

        public static int luaL_loadbufferx(this LuaState luaState, string buff, IntPtr size, string name, string mode) => Lua.luaL_loadbufferx(luaState, buff, size, name, mode);

        public static int luaL_loadfile(this LuaState luaState, string filename) => Lua.luaL_loadfile(luaState, filename);

        public static int luaL_loadfilex(this LuaState luaState, string filename, string mode) => Lua.luaL_loadfilex(luaState, filename, mode);

        public static int luaL_loadstring(this LuaState luaState, string s) => Lua.luaL_loadstring(luaState, s);

        public static int luaL_newmetatable(this LuaState luaState, string tname) => Lua.luaL_newmetatable(luaState, tname);

        public static int luaL_newmetatable_type(this LuaState luaState, string tname, int tnum) => Lua.luaL_newmetatable_type(luaState, tname, tnum);

        public static void luaL_openlib(this LuaState luaState, string libname, luaL_Reg[] l, int nup) => Lua.luaL_openlib(luaState, libname, l, nup);

        public static void luaL_openlibs(this LuaState luaState) => Lua.luaL_openlibs(luaState);

        public static int luaL_optinteger(this LuaState luaState, int arg, int def) => Lua.luaL_optinteger(luaState, arg, def);

        public static string luaL_optlstring(this LuaState luaState, int arg, string def, IntPtr len) => Lua.luaL_optlstring(luaState, arg, def, len);

        public static double luaL_optnumber(this LuaState luaState, int arg, double def) => Lua.luaL_optnumber(luaState, arg, def);

        public static char[] luaL_prepbuffer(this luaL_Buffer buffer) => Lua.luaL_prepbuffer(buffer);

        public static void luaL_pushresult(this luaL_Buffer buffer) => Lua.luaL_pushresult(buffer);

        public static int luaL_ref(this LuaState luaState, int t) => Lua.luaL_ref(luaState, t);

        public static void luaL_register(this LuaState luaState, string libname, luaL_Reg[] l) => Lua.luaL_register(luaState, libname, l);

        public static void luaL_traceback(this LuaState luaState, LuaState luaState1, string msg, int level) => Lua.luaL_traceback(luaState, luaState1, msg, level);

        public static int luaL_typerror(this LuaState luaState, int narg, string tname) => Lua.luaL_typerror(luaState, narg, tname);

        public static void luaL_unref(this LuaState luaState, int t, int @ref) => Lua.luaL_unref(luaState, t, @ref);

        public static void luaL_where(this LuaState luaState, int level) => Lua.luaL_where(luaState, level);

        public static int luaopen_base(this LuaState luaState) => Lua.luaopen_base(luaState);

        public static int luaopen_bit(this LuaState luaState) => Lua.luaopen_bit(luaState);

        public static int luaopen_debug(this LuaState luaState) => Lua.luaopen_debug(luaState);

        public static int luaopen_jit(this LuaState luaState) => Lua.luaopen_jit(luaState);

        public static int luaopen_math(this LuaState luaState) => Lua.luaopen_math(luaState);

        public static int luaopen_os(this LuaState luaState) => Lua.luaopen_os(luaState);

        public static int luaopen_package(this LuaState luaState) => Lua.luaopen_package(luaState);

        public static int luaopen_string(this LuaState luaState) => Lua.luaopen_string(luaState);

        public static int luaopen_table(this LuaState luaState) => Lua.luaopen_table(luaState);

        public static lua_CFunction lua_atpanic(this LuaState luaState, lua_CFunction panicf) => Lua.lua_atpanic(luaState, panicf);

        public static void lua_call(this LuaState luaState, int nargs, int nresults) => Lua.lua_call(luaState, nargs, nresults);

        public static int lua_checkstack(this LuaState luaState, int extra) => Lua.lua_checkstack(luaState, extra);

        public static void lua_close(this LuaState luaState) => Lua.lua_close(luaState);

        public static void lua_concat(this LuaState luaState, int n) => Lua.lua_concat(luaState, n);

        public static unsafe int lua_cpcall(this LuaState luaState, lua_CFunction func, void* ud) => Lua.lua_cpcall(luaState, func, ud);

        public static void lua_createtable(this LuaState luaState, int narr = 0, int nrec = 0) => Lua.lua_createtable(luaState, narr, nrec);

        public static void lua_newtable(this LuaState luaState) => Lua.lua_newtable(luaState);

        public static unsafe int lua_dump(this LuaState luaState, lua_Writer writer, void* data) => Lua.lua_dump(luaState, writer, data);

        public static int lua_equal(this LuaState luaState, int index1, int index2) => Lua.lua_equal(luaState, index1, index2);

        public static int lua_error(this LuaState luaState) => Lua.lua_error(luaState);

        public static int lua_gc(this LuaState luaState, int what, int data) => Lua.lua_gc(luaState, what, data);

        public static unsafe lua_Alloc lua_getallocf(this LuaState luaState, void** ud) => Lua.lua_getallocf(luaState, ud);

        public static void lua_getfenv(this LuaState luaState, int index) => Lua.lua_getfenv(luaState, index);

        public static void lua_getfield(this LuaState luaState, int index, string k) => Lua.lua_getfield(luaState, index, k);

        public static void lua_getfield(this LuaState luaState, TableIndex index, string k) => Lua.lua_getfield(luaState, index, k);

        public static void lua_getglobal(this LuaState luaState, string k) => Lua.lua_getglobal(luaState, k);

        public static lua_Hook lua_gethook(this LuaState luaState) => Lua.lua_gethook(luaState);

        public static int lua_gethookcount(this LuaState luaState) => Lua.lua_gethookcount(luaState);

        public static int lua_gethookmask(this LuaState luaState) => Lua.lua_gethookmask(luaState);

        public static int lua_getinfo(this LuaState luaState, string what, lua_Debug ar) => Lua.lua_getinfo(luaState, what, ar);

        public static string lua_getlocal(this LuaState luaState, lua_Debug ar, int n) => Lua.lua_getlocal(luaState, ar, n);

        public static int lua_getmetatable(this LuaState luaState, int index) => Lua.lua_getmetatable(luaState, index);

        public static int lua_getstack(this LuaState luaState, int level, lua_Debug ar) => Lua.lua_getstack(luaState, level, ar);

        public static void lua_gettable(this LuaState luaState, int index) => Lua.lua_gettable(luaState, index);

        public static int lua_gettop(this LuaState luaState) => Lua.lua_gettop(luaState);

        public static string lua_getupvalue(this LuaState luaState, int funcindex, int n) => Lua.lua_getupvalue(luaState, funcindex, n);

        public static void lua_insert(this LuaState luaState, int index) => Lua.lua_insert(luaState, index);

        public static int lua_iscfunction(this LuaState luaState, int index) => Lua.lua_iscfunction(luaState, index);

        public static int lua_isnumber(this LuaState luaState, int index) => Lua.lua_isnumber(luaState, index);

        public static int lua_isstring(this LuaState luaState, int index) => Lua.lua_isstring(luaState, index);

        public static int lua_isuserdata(this LuaState luaState, int index) => Lua.lua_isuserdata(luaState, index);

        public static int lua_lessthan(this LuaState luaState, int index1, int index2) => Lua.lua_lessthan(luaState, index1, index2);

        public static unsafe int lua_load(this LuaState luaState, lua_Reader reader, void* data, string chunkname) => Lua.lua_load(luaState, reader, data, chunkname);

        public static unsafe int lua_loadx(this LuaState luaState, lua_Reader reader, void* dt, string chunkname, string mode) => Lua.lua_loadx(luaState, reader, dt, chunkname, mode);

        public static unsafe LuaState lua_newstate(this lua_Alloc f, void* ud) => Lua.lua_newstate(f, ud);

        public static LuaState lua_newthread(this LuaState luaState) => Lua.lua_newthread(luaState);

        public static unsafe void* lua_newuserdata(this LuaState luaState, IntPtr size) => Lua.lua_newuserdata(luaState, size);

        public static int lua_next(this LuaState luaState, int index) => Lua.lua_next(luaState, index);

        public static IntPtr lua_objlen(this LuaState luaState, int index) => Lua.lua_objlen(luaState, index);

        public static int lua_pcall(this LuaState luaState, int nargs = 0, int nresults = 0, int msgh = 0) => Lua.lua_pcall(luaState, nargs, nresults, msgh);

        public static void lua_pushboolean(this LuaState luaState, int b) => Lua.lua_pushboolean(luaState, b);

        public static void lua_pushboolean(this LuaState luaState, bool b) => Lua.lua_pushboolean(luaState, b);

        public static void lua_pushcclosure(this LuaState luaState, lua_CFunction fn, int n) => Lua.lua_pushcclosure(luaState, fn, n);

        public static string lua_pushfstring(this LuaState luaState, string fmt, params object[] args) => Lua.lua_pushfstring(luaState, fmt, args);

        public static void lua_pushinteger(this LuaState luaState, int n) => Lua.lua_pushinteger(luaState, n);

        public static unsafe void lua_pushlightuserdata(this LuaState luaState, void* p) => Lua.lua_pushlightuserdata(luaState, p);

        public static void lua_pushlstring(this LuaState luaState, string s, IntPtr len) => Lua.lua_pushlstring(luaState, s, len);

        public static void lua_pushnil(this LuaState luaState) => Lua.lua_pushnil(luaState);

        public static void lua_pushnumber(this LuaState luaState, double n) => Lua.lua_pushnumber(luaState, n);

        public static void lua_pushstring(this LuaState luaState, [MarshalAs(UnmanagedType.LPStr)] string s) => Lua.lua_pushstring(luaState, s);

        public static int lua_pushthread(this LuaState luaState) => Lua.lua_pushthread(luaState);

        public static void lua_pushvalue(this LuaState luaState, int index) => Lua.lua_pushvalue(luaState, index);

        public static string lua_pushvfstring(this LuaState luaState, string fmt, ArgIterator argp) => Lua.lua_pushvfstring(luaState, fmt, argp);

        public static int lua_rawequal(this LuaState luaState, int index1, int index2) => Lua.lua_rawequal(luaState, index1, index2);

        public static void lua_rawget(this LuaState luaState, int index) => Lua.lua_rawget(luaState, index);

        public static void lua_rawgeti(this LuaState luaState, int index, int n) => Lua.lua_rawgeti(luaState, index, n);

        public static void lua_rawset(this LuaState luaState, int index) => Lua.lua_rawset(luaState, index);

        public static void lua_rawseti(this LuaState luaState, int index, int n) => Lua.lua_rawseti(luaState, index, n);

        public static void lua_remove(this LuaState luaState, int index) => Lua.lua_remove(luaState, index);

        public static void lua_replace(this LuaState luaState, int index) => Lua.lua_replace(luaState, index);

        public static void lua_resume_real(this LuaState luaState, int narg) => Lua.lua_resume_real(luaState, narg);

        public static unsafe void lua_setallocf(this LuaState luaState, lua_Alloc f, void* ud) => Lua.lua_setallocf(luaState, f, ud);

        public static int lua_setfenv(this LuaState luaState, int index) => Lua.lua_setfenv(luaState, index);

        public static void lua_setfield(this LuaState luaState, int index, string k) => Lua.lua_setfield(luaState, index, k);

        public static void lua_setglobal(LuaState luaState, string k) => Lua.lua_setglobal(luaState, k);

        public static int lua_sethook(this LuaState luaState, lua_Hook f, int mask, int count) => Lua.lua_sethook(luaState, f, mask, count);

        public static string lua_setlocal(this LuaState luaState, lua_Debug ar, int n) => Lua.lua_setlocal(luaState, ar, n);

        public static int lua_setmetatable(this LuaState luaState, int index) => Lua.lua_setmetatable(luaState, index);

        public static void lua_settable(this LuaState luaState, int index) => Lua.lua_settable(luaState, index);

        public static void lua_settop(this LuaState luaState, int index) => Lua.lua_settop(luaState, index);

        public static string lua_setupvalue(this LuaState luaState, int funcindex, int n) => Lua.lua_setupvalue(luaState, funcindex, n);

        public static int lua_status(this LuaState luaState) => Lua.lua_status(luaState);

        public static int lua_toboolean(this LuaState luaState, int index = -1) => Lua.lua_toboolean(luaState, index);

        public static lua_CFunction lua_tocfunction(this LuaState luaState, int index = -1) => Lua.lua_tocfunction(luaState, index);

        public static int lua_tointeger(this LuaState luaState, int index = -1) => Lua.lua_tointeger(luaState, index);

        public static IntPtr lua_tolstring(this LuaState luaState, int index, IntPtr len) => Lua.lua_tolstring(luaState, index, len);

        public static IntPtr lua_tostring(this LuaState luaState, int index = -1) => Lua.lua_tostring(luaState, index);

        public static double lua_tonumber(this LuaState luaState, int index = -1) => Lua.lua_tonumber(luaState, index);

        public static unsafe void* lua_topointer(this LuaState luaState, int index = -1) => Lua.lua_topointer(luaState, index);

        public static LuaState lua_tothread(this LuaState luaState, int index = -1) => Lua.lua_tothread(luaState, index);

        public static unsafe void* lua_touserdata(this LuaState luaState, int index = -1) => Lua.lua_touserdata(luaState, index);

        public static int lua_type(this LuaState luaState, int index) => Lua.lua_type(luaState, index);

        public static bool lua_type(this LuaState luaState, int index, Type type) => Lua.lua_type(luaState, index, type);

        public static string lua_typename(this LuaState luaState, int tp) => Lua.lua_typename(luaState, tp);

        public static unsafe void* lua_upvalueid(this LuaState luaState, int funcindex, int n) => Lua.lua_upvalueid(luaState, funcindex, n);

        public static void lua_upvaluejoin(this LuaState luaState, int funcindex1, int n1, int funcindex2, int n2) => Lua.lua_upvaluejoin(luaState, funcindex1, n1, funcindex2, n2);

        public static void lua_xmove(this LuaState from, LuaState to, int n) => Lua.lua_xmove(from, to, n);

        public static int lua_yield(this LuaState luaState, int nresults) => Lua.lua_yield(luaState, nresults);

        public static void lua_pop(this LuaState luaState, int num = 1) => Lua.lua_pop(luaState, num);

        public static void lua_pushobject(this LuaState luaState, object value) => Lua.lua_pushobject(luaState, value);

        public static int AbsIndex(this LuaState luaState, int index) => Lua.AbsIndex(luaState, index);

        public static string CheckManagedString(this LuaState luaState, int index) => Lua.CheckManagedString(luaState, index);

        public static string ToManagedString(this LuaState luaState, int index = -1) => Lua.ToManagedString(luaState, index);

        public static void RegisterCFunction(this LuaState luaState, string tableName, string funcName, lua_CFunction function) => Lua.RegisterCFunction(luaState, tableName, funcName, function);

        public static bool IsFalse(this int value) => value == 0;

        public static bool IsTrue(this int value) => value == 1;

        public static bool Is(this Type type, Type otherType) => type == otherType;

        public static void Init(this LuaState luaState) => Lua.Init(luaState);

        public static Angle ToAngle(this LuaObject luaObject) => new Angle(luaObject.GetIndex());

#if CLIENT
        public static bf_read Tobf_read(this LuaObject luaObject) => new bf_read(luaObject.GetIndex());
#endif

        public static CEffectData ToCEffectData(this LuaObject luaObject) => new CEffectData(luaObject.GetIndex());

        public static CLuaEmitter ToCLuaEmitter(this LuaObject luaObject) => new CLuaEmitter(luaObject.GetIndex());

        public static CLuaLocomotion ToCLuaLocomotion(this LuaObject luaObject) => new CLuaLocomotion(luaObject.GetIndex());

        public static CLuaParticle ToCLuaParticle(this LuaObject luaObject) => new CLuaParticle(luaObject.GetIndex());

        public static CMoveData ToCMoveData(this LuaObject luaObject) => new CMoveData(luaObject.GetIndex());

        public static CNavArea ToCNavArea(this LuaObject luaObject) => new CNavArea(luaObject.GetIndex());

        public static CNavLadder ToCNavLadder(this LuaObject luaObject) => new CNavLadder(luaObject.GetIndex());

        public static CRecipientFilter ToCRecipientFilter(this LuaObject luaObject) => new CRecipientFilter(luaObject.GetIndex());

        public static CSEnt ToCSEnt(this LuaObject luaObject) => new CSEnt(luaObject.GetIndex());

        public static CSoundPatch ToCSoundPatch(this LuaObject luaObject) => new CSoundPatch(luaObject.GetIndex());

        public static CTakeDamageInfo ToCTakeDamageInfo(this LuaObject luaObject) => new CTakeDamageInfo(luaObject.GetIndex());

        public static CUserCmd ToCUserCmd(this LuaObject luaObject) => new CUserCmd(luaObject.GetIndex());

        public static ConVar ToConVar(this LuaObject luaObject) => new ConVar(luaObject.GetIndex());

        public static Entity ToEntity(this LuaObject luaObject) => new Entity(luaObject.GetIndex());

        public static File ToFile(this LuaObject luaObject) => new File(luaObject.GetIndex());

        public static IGModAudioChannel ToIGModAudioChannel(this LuaObject luaObject) => new IGModAudioChannel(luaObject.GetIndex());

        public static IMaterial ToIMaterial(this LuaObject luaObject) => new IMaterial(luaObject.GetIndex());

        public static IMesh ToIMesh(this LuaObject luaObject) => new IMesh(luaObject.GetIndex());

        public static IRestore ToIRestore(this LuaObject luaObject) => new IRestore(luaObject.GetIndex());

        public static ISave ToISave(this LuaObject luaObject) => new ISave(luaObject.GetIndex());

        public static ITexture ToITexture(this LuaObject luaObject) => new ITexture(luaObject.GetIndex());

        public static IVideoWriter ToIVideoWriter(this LuaObject luaObject) => new IVideoWriter(luaObject.GetIndex());

        public static MarkupObject ToMarkupObject(this LuaObject luaObject) => new MarkupObject(luaObject.GetIndex());

        public static NPC ToNPC(this LuaObject luaObject) => new NPC(luaObject.GetIndex());

        public static NextBot ToNextBot(this LuaObject luaObject) => new NextBot(luaObject.GetIndex());

        public static Panel ToPanel(this LuaObject luaObject) => new Panel(luaObject.GetIndex());

        public static PathFollower ToPathFollower(this LuaObject luaObject) => new PathFollower(luaObject.GetIndex());

        public static PhysObj ToPhysObj(this LuaObject luaObject) => new PhysObj(luaObject.GetIndex());

        public static Player ToPlayer(this LuaObject luaObject) => new Player(luaObject.GetIndex());

        public static Schedule ToSchedule(this LuaObject luaObject) => new Schedule(luaObject.GetIndex());

        public static Stack ToStack(this LuaObject luaObject) => new Stack(luaObject.GetIndex());

        public static TOOL ToTOOL(this LuaObject luaObject) => new TOOL(luaObject.GetIndex());

        public static LuaTable ToTable(this LuaObject luaObject) => new LuaTable(luaObject.GetIndex());

        public static Task ToTask(this LuaObject luaObject) => new Task(luaObject.GetIndex());

        public static VMatrix ToVMatrix(this LuaObject luaObject) => new VMatrix(luaObject.GetIndex());

        public static Vector ToVector(this LuaObject luaObject) => new Vector(luaObject.GetIndex());

        public static Vehicle ToVehicle(this LuaObject luaObject) => new Vehicle(luaObject.GetIndex());

        public static Weapon ToWeapon(this LuaObject luaObject) => new Weapon(luaObject.GetIndex());
    }
}