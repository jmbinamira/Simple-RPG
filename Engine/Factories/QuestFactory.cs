using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class QuestFactory
    {
        //List to store quest objects.
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory() 
        {
            //Declares the items req. for quest completion/reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 10));
            rewardItems.Add(new ItemQuantity(1002, 5));

            //Creates the quest (adds it to the quest list)
            _quests.Add(new Quest(1, "Red flowering.",
                "Gather red flowers in the field filled with strange creatures.",
                30, 15, itemsToComplete, rewardItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
