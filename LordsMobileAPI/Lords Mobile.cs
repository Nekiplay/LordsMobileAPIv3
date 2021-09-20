using Process.NET;
using Process.NET.Memory;

namespace LordsMobileAPI
{
    public class LordsMobile
    {
        public LordsMobile()
        {
            Game = new ProcessSharp(pointers.Game, MemoryType.Local);
            Game.Memory = new ExternalProcessMemory(Game.Handle);
            resource = new Resources(Game, pointers, Game.ModuleFactory["GameAssembly.dll"].BaseAddress);
            user = new UserInfo(Game, pointers, Game.ModuleFactory["GameAssembly.dll"].BaseAddress);

        }
        public Resources resource { get; }
        public UserInfo user { get; }

        public ProcessSharp Game;
        private Pointers pointers = new Pointers();
    }
}
