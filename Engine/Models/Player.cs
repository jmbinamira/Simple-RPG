using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        public string Name { get; set; }  //Properties/Attributes of the class Player
        public string CharClass { get; set; }
        public double Health { get; set; }
        public double ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Gold {  get; set; }

    }
}
