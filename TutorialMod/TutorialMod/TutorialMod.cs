using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMod
{
    public class TutorialMod : IUserMod
    {
        public static readonly string Version = "1.0.0";

        public string Name => "Tutorial Mod [" + Version + "]";

        public string Description => "This is a mod that is a tutorial!";

        public void OnEnabled()
        {
            Log.Info($"Tutorial Mod enabled. Version {Version}, Build {Assembly.GetExecutingAssembly().GetName().Version}");
        }

        public void OnDisabled()
        {
            Log.Info($"Tutorial Mod disabled. ");
        }
    }
}
