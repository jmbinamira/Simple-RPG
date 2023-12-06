using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;  //Gets Player(), Location() class on ./Models/Player.cs
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location _currentLocation;       
        
        public World CurrentWorld { get; set; }
        
        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToSouth");
            }
        }

        public bool HasLocationToNorth
        {
            get 
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            } 
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

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

        public void MoveNorth()  //Public since we're calling another function from the WPFUI project
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
