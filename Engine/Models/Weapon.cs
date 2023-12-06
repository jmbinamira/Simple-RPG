using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        
        //Creating the weapon object, the 5 parameters are sent to the GameItem parameter.
        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage) : base(itemTypeID, name, price)  
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamage, MaximumDamage);
        }
    }
}
