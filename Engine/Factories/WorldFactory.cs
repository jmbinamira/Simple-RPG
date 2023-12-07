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

            newWorld.AddLocation(-1, -1, "Farm House",
                "Area where farm animals go for shelter.",
                "pack://application:,,,/Engine;component/Images/Locations/farmhouse.png");

            newWorld.AddLocation(0, -1, "Home", 
                "Your home", 
                "pack://application:,,,/Engine;component/Images/Locations/home.png");

            newWorld.AddLocation(0, 0, "Town Center",
                "Main social hub of the town.",
                "pack://application:,,,/Engine;component/Images/Locations/towncenter.png");

            newWorld.AddLocation(-1, 0, "Merchant Store",
                "Local store where all kinds of items are traded.",
                "pack://application:,,,/Engine;component/Images/Locations/merchantstore.png");

            newWorld.AddLocation(0, 1, "Alchemy Store",
                "Where an alchemist/wizard resides to sell tomes and potions.",
                "pack://application:,,,/Engine;component/Images/Locations/alchemystore.png");

            newWorld.AddLocation(0, 2, "Alchemist's Field",
                "Full of colorful plants, mushrooms, and critters.",
                "pack://application:,,,/Engine;component/Images/Locations/alchemyfield.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "The only thing that protects the city from the outside world.",
                "pack://application:,,,/Engine;component/Images/Locations/towngate.png");

            newWorld.AddLocation(2, 0, "Haunted Mound",
                "Otherworldly and demonic creatures roam free in this area.",
                "pack://application:,,,/Engine;component/Images/Locations/hauntedmound.png");

            return newWorld;
        }
    }
}


/*
> Static since it is globally available. Since there are many locations, a factory class is needed to create other objects.
> CreateWorld can only be used inside the Engine project. It returns a world object.
> For images to appear, Engine.csproj is modified by adding .WindowsDesktop at ProjectSdk.
 */ 