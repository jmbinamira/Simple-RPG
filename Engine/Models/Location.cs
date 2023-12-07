using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate {  get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        //List of quests per location
        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();

    }
}


/*
> QuestAvailableHere is set to a new List<Quest> initializes it with an empty list to start with (no need for a constructor)/
*/
