#if SOURCE_SDK
using System.Runtime.InteropServices;

namespace GarrysModLuaShared.Source
{
    static class IVEngineClient
    {
        /// <summary>
        ///     Inserts <paramref name="cmdString" /> into the command buffer as if it was typed by the client to his/her
        ///     console.
        ///     <para />
        ///     Note: Calls to this are checked against <see cref="Enums.FCVAR.FCVAR_CLIENTCMD_CAN_EXECUTE" /> (if that bit is not
        ///     set, then this function can't change it).
        ///     <para />
        ///     Call <see cref="ClientCmd_Unrestricted" /> to have access to <see cref="Enums.FCVAR.FCVAR_CLIENTCMD_CAN_EXECUTE" />
        ///     vars.
        /// </summary>
        /// <param name="cmdString">Command to insert.</param>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClientCmd@IVEngineClient@SourceExports@@CAXPBD@Z", SetLastError = true)]
        public static extern void ClientCmd(string cmdString);

        /// <summary>This version does NOT check against <see cref="Enums.FCVAR.FCVAR_CLIENTCMD_CAN_EXECUTE" />.</summary>
        /// <param name="cmdString">Command to insert.</param>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClientCmd_Unrestricted@IVEngineClient@SourceExports@@CAXPBD@Z", SetLastError = true)]
        public static extern void ClientCmd_Unrestricted(string cmdString);

        /// <summary>
        ///     Inserts <paramref name="cmdString" /> into the command buffer as if it was typed by the client to his/her
        ///     console.
        ///     <para />
        ///     And then executes the command string immediately (vs <see cref="ClientCmd" /> which executes in the next frame).
        ///     <para />
        ///     Note: This is NOT checked against the <see cref="Enums.FCVAR.FCVAR_CLIENTCMD_CAN_EXECUTE" /> vars.
        /// </summary>
        /// <param name="cmdString">Command to insert.</param>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ExecuteClientCmd@IVEngineClient@SourceExports@@CAXPBD@Z", SetLastError = true)]
        public static extern void ExecuteClientCmd(string cmdString);

        /// <summary>Gets the dimensions of the game window.</summary>
        /// <param name="width">Width (in pixels).</param>
        /// <param name="height">Height (in pixels).</param>
        [DllImport(ExternDll.SourceExports, CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetScreenSize@IVEngineClient@SourceExports@@CAXAAH0@Z", SetLastError = true)]
        public static extern void GetScreenSize(ref int width, ref int height);
    }
}
#endif