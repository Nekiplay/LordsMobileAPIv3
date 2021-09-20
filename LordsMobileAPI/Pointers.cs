using Process.NET;
using Process.NET.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LordsMobileAPI
{
    public class Pointers
    {
        private ProcessSharp processSharp;
        public Pointers()
        {
            processSharp = new ProcessSharp(Game, Process.NET.Memory.MemoryType.Local);
            processSharp.Memory = new ExternalProcessMemory(processSharp.Handle);
        }
        public class Resources
        {
            public static List<int> Food = new List<int>{ 0x02663AE8, 0x48, 0x40, 0xB8, 0x18, 0x1A0 };
            public static List<int> Stone = new List<int> { 0x02663AE8, 0x48, 0x40, 0xB8, 0x18, 0x150 };
            public static List<int> Wood = new List<int> { 0x02663AE8, 0x48, 0x40, 0xB8, 0x18, 0x100 };
            public static List<int> Ore = new List<int> { 0x02663AE8, 0x48, 0x40, 0xB8, 0x18, 0xB0 };
            public static List<int> Gold = new List<int> { 0x02663AE8, 0x48, 0x40, 0xB8, 0x18, 0x60 };
        }
        public class UserInfo
        {
            public static List<int> Stamina = new List<int> { 0x025988D0, 0x50, 0x40, 0xB8, 0x18, 0x38C };
        }
        public System.Diagnostics.Process Game
        {
            get
            {
                System.Diagnostics.Process game = System.Diagnostics.Process.GetProcessesByName("Lords Mobile").FirstOrDefault();
                return game;
            }
        }
        public long ReadOffset(long baseAddres, List<int> offsets)
        {
            for (int i = 0; i < offsets.Count() - 1; i++)
            {
                baseAddres = (long)processSharp.Memory.Read<long>(IntPtr.Add((IntPtr)baseAddres, offsets[i]));
            }
            return baseAddres + offsets[offsets.Count() - 1];
        }
        public IntPtr getModuleAdress(string modulname)
        {
            IntPtr result = IntPtr.Zero;
            for (int i = 0; i < Game.Modules.Count; i++)
            {
                if (Game.Modules[i].ModuleName == modulname)
                {
                    result = Game.Modules[i].BaseAddress;
                    break;
                }
            }
            return result;
        }
        public IntPtr ReadOffset(IntPtr baseAddres, List<int> offsets)
        {
            for (int i = 0; i < offsets.Count() - 1; i++)
            {
                baseAddres = processSharp.Memory.Read<IntPtr>(IntPtr.Add(baseAddres, offsets[i]));
            }
            return baseAddres + offsets[offsets.Count() - 1];
        }
    }
}
