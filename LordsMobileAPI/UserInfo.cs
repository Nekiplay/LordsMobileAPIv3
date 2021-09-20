using Process.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LordsMobileAPI
{
    public class UserInfo
    {
        private ProcessSharp processSharp;
        private Pointers pointers;
        public UserInfo(ProcessSharp processSharp, Pointers pointers, IntPtr module)
        {
            this.processSharp = processSharp;
            this.pointers = pointers;
        }
        public int Stamina
        {
            get
            {
                return processSharp.Memory.Read<int>(pointers.ReadOffset(processSharp.ModuleFactory["GameAssembly.dll"].BaseAddress, Pointers.UserInfo.Stamina));
            }
        }
    }
}
