using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        //Functions that accepts monsterID and creates monster object
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster wolf = new Monster("Wolf", "wolf.png", 5, 5, 10, 1);
                    AddLootItem(wolf, 9001, 25);
                    AddLootItem(wolf, 9002, 75);
                    return wolf;
                case 2:
                    Monster skeever = new Monster("Skeever", "skeever.png", 3, 3, 5, 1);
                    AddLootItem(skeever, 9003, 25);
                    AddLootItem(skeever, 9004, 75);
                    return skeever;
                case 3:
                    Monster daedra = new Monster("Daedra", "daedra.png", 100, 100, 500, 100);
                    AddLootItem(daedra, 9005, 25);
                    AddLootItem(daedra, 9006, 75);
                    return daedra;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exit", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage) 
        { 
            if (RandomNumberGenerator.NumberBetween(1,100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
