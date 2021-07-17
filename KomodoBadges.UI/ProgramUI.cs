using KomodoBadgesClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges.UI
{
    public class ProgramUI
    {
        private BadgeRepository _newBadge = new BadgeRepository();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Hello Security Admin. What would you like to do?\n\n" +
                                  "***********************\n" +
                                  "1. Add a Badge.\n" +
                                  "2. Edit a Badge.\n" +
                                  "3. List All Badges.\n" +
                                  "4. Remove a Door from a Badge.\n" +
                                  "5. Exit\n" +
                                  "***********************\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditABadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        DeleteDoorsFromBadge();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid option.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        private void AddABadge()
        {
            bool keepRunning = true;
            Console.Clear();
            Badge newBadge = new Badge();

            Console.WriteLine("What is the number on the badge: ");
            newBadge.BadgeID = int.Parse(Console.ReadLine());

            while (keepRunning)
            {
                Console.WriteLine("List a door that it needs access to: ");
                List<string> doorNames = new List<string>();
                Console.ReadLine().ToUpper();
                foreach (var door in doorNames)
                {
                    Console.WriteLine(door);
                }

                Console.WriteLine("Any other doors? (y/n)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        foreach (var door in doorNames)
                        {
                            Console.WriteLine(door);
                        }
                        break;
                    case "n":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option: (y/n)");
                        break;
                }
            }

            _newBadge.AddDoors(newBadge);
        }

        private void EditABadge()
        {
            Console.Clear();
            ListAllBadges();
            List<string> doorNames = new List<string>();
            Console.WriteLine("Enter the Badge Number you would like to view: ");
            string badge = Console.ReadLine();

            Badge newbadge = _newBadge.GetBadgeByID(badge);

            if(newbadge != null)
            {
                Console.WriteLine($"BadgeID: {newbadge.BadgeID}\n" +
                                  $"Door Access: {newbadge.DoorNames}\n" +
                                  $"**********************************\n\n");

                if(newbadge != null)
                {
                    Console.WriteLine("What would you like to do?");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            RemoveADoor();
                            break;
                        case "2":
                            AddADoor();
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Could not find that badge number...");
            }
        }

        private void ListAllBadges()
        {
            Console.Clear();

            List<Badge> _listOfDoors = _newBadge.GetDoorNames();

            foreach (Badge doorName in _listOfDoors)
            {
                Console.WriteLine($"BadgeID: {doorName.BadgeID}\n" +
                                  $"Door Access: {doorName.DoorNames}\n" +
                                  $"***********************************\n\n");
            }
        }

        private void DeleteDoorsFromBadge()
        {
            ListAllBadges();

            Console.WriteLine("Enter Door you would like to remove: ");
            string input = Console.ReadLine();

            bool wasDeleted = _newBadge.DeleteDoorsFromList(input);

            if (wasDeleted)
            {
                Console.WriteLine("The door was successfully removed.");
            }
            else
            {
                Console.WriteLine("The door could not be removed.");
            }
        }

        //EditABadge
        private void RemoveADoor()
        {
            Console.WriteLine("Enter the door you would like to remove from the badge: ");
            string input = Console.ReadLine();
            Badge badge = new Badge();

            bool wasDeleted = _newBadge.DeleteDoorsFromList(input);

            if (wasDeleted)
            {
                Console.WriteLine($"The Door was successfully removed. The badge now has access to {badge.DoorNames}");
            }
            else
            {
                Console.WriteLine("The Door could not be removed.");
            }
        }

        private void AddADoor()
        {
            Console.WriteLine("Enter the door you would like to add to the badge: ");
            string input = Console.ReadLine();
            Badge badge = new Badge();

            bool wasAdded = _newBadge.AddDoorsToList(input);

            if (wasAdded)
            {
                Console.WriteLine($"The Door was successfully added. The badge now has access to {badge.DoorNames}");
            }
            else
            {
                Console.WriteLine("The Door could not be added.");
            }
        }

    }
}





