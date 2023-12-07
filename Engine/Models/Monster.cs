using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        private int _hp;

        public string Name { get; set; }
        public string ImageName { get; set; }
        public int MaxHP { get; set; }
        public int HP 
        { 
            get { return _hp; }
            private set
            {
                _hp = value;
                OnPropertyChanged(nameof(HP));
            }
        }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }

        //Loot item when a monster's defeated
        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        //Constructor
        public Monster(string name, string imageName, int maxHP, int hp, int rewardXP, int rewardGold)
        {
            Name = name;
            ImageName = imageName;
            MaxHP = maxHP;
            HP = hp;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}


/*
> HP's the only one with a backing variable since it's the only attribute that notifies the UI when a monster attribute changes
*/