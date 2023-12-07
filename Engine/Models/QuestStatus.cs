using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class QuestStatus
    {
        //Holds quest
        public Quest PlayerQuest { get; set; }
        public bool IsCompleted { get; set; }

        public QuestStatus(Quest quest) 
        {
            PlayerQuest = quest;
            IsCompleted = false;
        }
    }
}


/*
> The author notes that the status of the quest is in another class instead of the quest class itself is becaues of repeatability. We may want to repeat quest X or Y (new instances). 
*/
