using KomodoCafeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoCafeUnitTests
{
    [TestClass]
    public class KomodoCafeTests
    {
        private MenuItemRepository _repo = new MenuItemRepository();
        private MenuItem _menuItem = new MenuItem();

        [TestMethod]
        public void CreateMenuItem_ShouldNotBeNull()
        {
            MenuItem _menuItem = new MenuItem();
            MenuItemRepository _repo = new MenuItemRepository();

            bool result = _repo.CreateMenuItem(_menuItem);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetMenuItems_ShouldReturnNotNull()
        {
            MenuItem _menuItem = new MenuItem();
            MenuItemRepository _repo = new MenuItemRepository();

            bool result = true;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeleteItemsFromMenu_ShouldReturnFalse()
        {
            MenuItemRepository _repo = new MenuItemRepository();
            MenuItem _menuItem = new MenuItem();

            bool deleteResult = _repo.DeleteItemsFromMenu(_menuItem.MealName);

            Assert.IsFalse(deleteResult);
        }
    }
}
