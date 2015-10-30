using System;

namespace GarrysModLuaShared
{
    static class Random
    {
        internal static readonly System.Random Generator = new System.Random((int)(DateTime.Now.Ticks + Environment.TickCount));
    }
}