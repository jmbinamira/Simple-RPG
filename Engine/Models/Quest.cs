using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    //Public!
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }

        //List of req. items for the quest to complete
        public List<ItemQuantity> ItemsToComplete { get; set; }

        //List of items rewarded for quest completion
        public List<ItemQuantity> RewardItems { get; set; }

        public Quest(int id, string name, string description, int rewardXP, int rewardGold, List<ItemQuantity> itemsToComplete, List<ItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            ItemsToComplete = itemsToComplete;
            RewardItems = rewardItems;
        }
    }
}
