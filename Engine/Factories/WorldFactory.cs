using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()  //Can only be used inside the Engine project. It returns a world object
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Tavern Open Area",
               "Extension of the tavern for more space.",
               "pack://application:,,,/Engine;component/Images/Locations/tavernopenarea.png");

            newWorld.AddLocation(-1, -1, "Tavern",
                "Tavern where locals can drink and socialize.",
                "pack://application:,,,/Engine;component/Images/Locations/tavern.png");

            newWorld.AddLocation(0, -1, "Home", 
                "Your home", 
                "pack://application:,,,/Engine;component/Images/Locations/home.png");  //Modified Engine.csproj by adding .WindowsDesktop at ProjectSdk

            return newWorld;
        }
    }
}
