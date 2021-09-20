using Process.NET;
using System;

namespace LordsMobileAPI
{
    public class Resources
    {
        private ProcessSharp processSharp;
        private Pointers pointers;
        public Resources(ProcessSharp processSharp, Pointers pointers, IntPtr module)
        {
            this.processSharp = processSharp;
            this.pointers = pointers;
        }
        public double Food
        {
            get
            {
                return processSharp.Memory.Read<double>(pointers.ReadOffset(processSharp.ModuleFactory["GameAssembly.dll"].BaseAddress, Pointers.Resources.Food));
            }
        }
        public double Stone
        {
            get
            {
                return processSharp.Memory.Read<double>(pointers.ReadOffset(processSharp.ModuleFactory["GameAssembly.dll"].BaseAddress, Pointers.Resources.Stone));
            }
        }
        public double Wood
        {
            get
            {
                return processSharp.Memory.Read<double>(pointers.ReadOffset(processSharp.ModuleFactory["GameAssembly.dll"].BaseAddress, Pointers.Resources.Wood));
            }
        }
        public double Ore
        {
            get
            {
                return processSharp.Memory.Read<double>(pointers.ReadOffset(processSharp.ModuleFactory["GameAssembly.dll"].BaseAddress, Pointers.Resources.Ore));
            }
        }
        public double Gold
        {
            get
            {
                return processSharp.Memory.Read<double>(pointers.ReadOffset(processSharp.ModuleFactory["GameAssembly.dll"].BaseAddress, Pointers.Resources.Gold));
            }
        }
    }
}
