using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();
        //Void since we're not returning anything
        internal void AddLocation(int XCoordinate, int YCoordinate, string Name, string Description, string ImageName) 
        {
            Location loc = new Location();
            loc.XCoordinate = XCoordinate;
            loc.YCoordinate = YCoordinate;
            loc.Name = Name;
            loc.Description = Description;
            loc.ImageName = ImageName;

            //Adds the newly created object to the list
            _locations.Add(loc);  
        }
        
        public Location LocationAt(int XCoordinate, int YCoordinate)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == XCoordinate && loc.YCoordinate == YCoordinate)
                {
                    return loc;

                }
            }

            return null;
        }
    }
}
