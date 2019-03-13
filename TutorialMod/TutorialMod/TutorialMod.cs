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
        public string Name => "Tutorial Mod";
        public string Description => "This is a mod that is a tutorial!";
    }
}
