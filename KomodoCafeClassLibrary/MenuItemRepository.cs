using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeClassLibrary
{
    public class MenuItemRepository
    {
        private List<MenuItem> _listOfMenuItems = new List<MenuItem>();

        public bool CreateMenuItem(MenuItem menuItem)
        {
            if(menuItem is null)
            {
                return false;
            }

            _listOfMenuItems.Add(menuItem);
            return true;
        }

        public List<MenuItem> GetMenuItems()
        {
            return _listOfMenuItems;
        }

        public bool DeleteItemsFromMenu(string itemOnMenu)
        {
            MenuItem menuItem = GetMenuItemsByName(itemOnMenu);

            if(menuItem == null)
            {
                return false;
            }

            int initialmenuItem = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(menuItem);

            if(_listOfMenuItems.Count < initialmenuItem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper Method
        public MenuItem GetMenuItemsByName(string mealName)
        {
            foreach (MenuItem menuItem in _listOfMenuItems)
            {
                if(menuItem.MealName.ToLower() == mealName.ToLower())
                {
                    return menuItem;
                }
            }

            return null;
        }

    }
}
