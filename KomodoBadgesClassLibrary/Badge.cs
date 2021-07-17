using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgesClassLibrary
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }

    public Badge()
    {

    }

        public Badge(int badgeID, List<string> doorNames, string listOfDoors)
        {
            this.BadgeID = badgeID;
            this.DoorNames = doorNames;
        }
    }
}


