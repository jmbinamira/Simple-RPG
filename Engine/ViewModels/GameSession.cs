using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;  //Gets Player(), Location() class on ./Models/Player.cs
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        
        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation { get; set; }

        public GameSession()  //Constructor (if we want to create a GameSession() object)
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "BLONDED2K";
            CurrentPlayer.CharClass = "Warrior";
            CurrentPlayer.Health = 100;
            CurrentPlayer.Gold = 0;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 0;

            WorldFactory factory = new WorldFactory();  //Since there are many locations, a factory class is needed to create other objects
            CurrentWorld = factory.CreateWorld();  //After creating a game session, it will create a WOrldFactory object, call the CreateWorld function (which creates a new world object
                                                   //and return it here and assign it to CurrentWorld property)

            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }
    }
}
