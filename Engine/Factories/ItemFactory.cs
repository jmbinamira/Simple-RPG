using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory  
    {
        //List contains all kinds of items.
        private static List<GameItem> _standardGameItems;  

        static ItemFactory()  
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Wooden Sword", 1, 2, 3));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 2, 5, 8));
            _standardGameItems.Add(new GameItem(9001, "Red Flower", 10));
            _standardGameItems.Add(new GameItem(9002, "Wolf Tail", 25));
        }

        public static GameItem CreateGameItem(int itemTypeID)  
        {
            //Uses LINQ to find the 1st item matches the ID that we passed.
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);  
            
            if (standardItem != null)
            { 
                return standardItem.Clone();
            }

            return null;
        }
    }
}


/*
> Static classes have no constructors.
> The 1st time someone calls a funciton in ItemFactory, the static ItemFactory will run. It initializes an empty list then adds items to it (required).
> CreateGameItem will create items for the list. The parameter will be passed to the list to find the matching ID using LINQ.
> Language-Integrated Query, query language to see what's inside of a list. standardItem will either have the ID on the list or null.
> It it has a matching ID, it will create a clone of it.
*/
