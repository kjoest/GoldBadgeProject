using KomodoCafeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe.UI
{
    public class ProgramUI
    {
        private MenuItemRepository _newMenuItem = new MenuItemRepository();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Please Select an Option:\n\n" +
                                  "*******************************\n" +
                                  "1. Add an Item to the Menu\n" +
                                  "2. Remove an Item from the Menu\n" +
                                  "3. Current Items on the Menu\n" +
                                  "4. Exit\n" +
                                  "*******************************");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddMenuItem();
                        break;
                    case "2":
                        RemoveMenuItem();
                        break;
                    case "3":
                        CurrentMenuItems();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("GoodBye!\n\n");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option...");
                        break;
                }

                Console.WriteLine("Press any key to contiue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void AddMenuItem()
        {
            bool keepRunning = true;
            Console.Clear();
            MenuItem newMenuItem = new MenuItem();

            Console.WriteLine("Enter the number of the new menu item: ");
            newMenuItem.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the new menu item: ");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("What is the description of the menu item?");
            newMenuItem.Description = Console.ReadLine();

            while (keepRunning)
            {
                Console.WriteLine("Would you like to add ingredients? (y/n)");
                string addIngredients = Console.ReadLine().ToLower();
                switch (addIngredients)
                {
                    case "y":
                        Console.WriteLine("What ingredient would you like to add?");
                        Console.ReadLine();
                        break;
                    case "n":
                        Console.WriteLine("No ingredient added.");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option: (y/n)");
                        break;
                }
            }

            Console.WriteLine("Enter the cost of the item:");
            newMenuItem.MealPrice = decimal.Parse(Console.ReadLine());

            _newMenuItem.CreateMenuItem(newMenuItem);
        }

        private void RemoveMenuItem()
        {
            Console.Clear();

            CurrentMenuItems();
            Console.WriteLine("What menu item would you like to remove?");
            string input = Console.ReadLine();

            bool wasDeleted = _newMenuItem.DeleteItemsFromMenu(input);

            if (wasDeleted)
            {
                Console.WriteLine("The Item was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The Item could not be deleted.");
            }
        }

        private void CurrentMenuItems()
        {
            Console.Clear();

            List<MenuItem> listOfMenuItems = _newMenuItem.GetMenuItems();

            foreach (MenuItem menuItem in listOfMenuItems)
            {
                Console.WriteLine($"Item Number: {menuItem.MealNumber}\n" +
                                  $"Item Name: {menuItem.MealName}\n" +
                                  $"Item Description: {menuItem.Description}\n" +
                                  $"Item Ingredients: {menuItem.Ingredients}\n" +
                                  $"Item Price: {menuItem.MealPrice}");
            }
        }
    }
}












