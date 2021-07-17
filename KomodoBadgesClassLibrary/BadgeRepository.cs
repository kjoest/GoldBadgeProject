using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgesClassLibrary
{
    public class BadgeRepository
    {
        private List<Badge> _listOfDoorNames = new List<Badge>();
        private List<Badge> _listOfBadges = new List<Badge>();
        Dictionary<int, string> Doors = new Dictionary<int, string>
        {
            {123, "DoorA1" },
            {210, "DoorA2" },
            {450, "DoorA3"},
            {430, "DoorA4" },
            {120, "DoorA5" },
            {115, "DoorA6" }
        };

        public bool AddDoors(Badge doorNames)
        {
            if(doorNames is null)
            {
                return false;
            }

            _listOfDoorNames.Add(doorNames);
            return true;
        }

        public List<Badge> GetDoorNames()
        {
            return _listOfDoorNames;
        }

        public bool UpDateDoorsOnExistingBadge(string originalDoor, Badge newBadge)
        {
            Badge oldbadge = GetDoorByName(originalDoor);

            if (originalDoor != null)
            {
                oldbadge.BadgeID = newBadge.BadgeID;
                oldbadge.DoorNames = newBadge.DoorNames;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDoorsFromList(string _doorName)
        {
            Badge doorName = GetDoorByName(_doorName);

            if(doorName == null)
            {
                return false;
            }

            int initialDoor = _listOfDoorNames.Count;
            _listOfDoorNames.Remove(doorName);

            if(_listOfDoorNames.Count < initialDoor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddDoorsToList(string _doorName)
        {
            Badge doorName = GetDoorByName(_doorName);

            if(doorName == null)
            {
                return false;
            }

            int initialDoor = _listOfDoorNames.Count;
            _listOfDoorNames.Add(doorName);

            if(_listOfDoorNames.Count < initialDoor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        public Badge GetDoorByName(string doorName)
        {
            foreach (Badge _doorNames in _listOfDoorNames)
            {
                if (_doorNames.ToString().ToLower() == doorName.ToLower())
                {
                    return _doorNames;
                }
            }

            return null;
        }

        //Helper Method
        public Badge GetBadgeByID(string badge)
        {
            foreach(Badge newbadge in _listOfDoorNames)
            {
                if (newbadge.BadgeID.ToString() == newbadge.ToString())
                {
                    return newbadge;
                }
            }

            return null;
        }
    }
}


