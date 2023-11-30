using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;  //Gets Player() class on ./Models/Player.cs

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()  //Constructor (if we want to create a GameSession() object)
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "BLONDED2K";
            CurrentPlayer.CharClass = "Warrior";
            CurrentPlayer.Health = 100;
            CurrentPlayer.Gold = 0;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 0;
        }
    }
}
