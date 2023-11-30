using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;  //Gets the Player class on ./Models/Player.cs

namespace Engine.ViewModels
{
    internal class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()  //Constructor (if we want to create a GameSession object)
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "BLONDED2K";
            CurrentPlayer.Gold = 1000000;
        }
    }
}
