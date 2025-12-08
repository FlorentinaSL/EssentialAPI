using System;
using LabApi.Features.Console;
using LabApi.Loader.Features.Plugins;

namespace EssentialAPI
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "SimpleAPI";
        public override string Description { get; } = "An API that contains all the features in a easier way!";
        public override string Author { get; } = "Mr.Cat <3";
        public override Version Version { get; } = new Version(1,0,0);
        public override Version RequiredApiVersion { get; } = new Version(1,1,4);
        
        public override void Enable()
        {
            Logger.Info("===== [SimpleAPI | Normal | API] =====");
            Logger.Info($"Version: {Version}");
            Logger.Info($"Author: {Author}");
            Logger.Info("Badge: None");
            Logger.Info("======================================");
        }

        public override void Disable()
        {
            Logger.Info("[SAPI]: Disabling API.");
        }
    }
}