using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory                                     
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farm Field",
               "Full of crops and other farm plants.",
               "pack://application:,,,/Engine;component/Images/Locations/farmfield.png");

            newWorld.AddLocation(-1, -1, "Farmhouse",
                "Area where farm animals go for shelter.",
                "pack://application:,,,/Engine;component/Images/Locations/farmhouse.png");

            newWorld.AddLocation(0, -1, "Home", 
                "Your home", 
                "pack://application:,,,/Engine;component/Images/Locations/home.png");                                                                                       

            return newWorld;
        }
    }
}


/*
> Static since it is globally available. Since there are many locations, a factory class is needed to create other objects.
> CreateWorld can only be used inside the Engine project. It returns a world object.
> For images to appear, Engine.csproj is modified by adding .WindowsDesktop at ProjectSdk.
 */ 