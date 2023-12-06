using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass  //Inherits the INotifyPropertyChanged from BaseNotificationClass
    {
        private string _name;
        private string _charClass;
        private double _health;
        private double _experiencePoints;
        private int _level;
        private int _gold;

        public string Name  //Properties/Attributes of the class Player
        {
            get { return _name; }  //Gets returns any properties from the backing variable
            set  //Sets saves it to the backing (private) variable and raises the INotifyPropertyChanged event w/ the propery name
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string CharClass
        {
            get { return _charClass; }
            set
            {
                _charClass = value;
                OnPropertyChanged(nameof(CharClass));
            }
        }
        public double Health
        {
            get { return _health; }
            set
            {
                _health = value;
                OnPropertyChanged(nameof(Health));
            }
        }
        public double ExperiencePoints
        {
            get { return _experiencePoints; }
            set 
            { 
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }
    }
}
