using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeClassLibrary
{
    public enum Ingredients
    {
        cheese,
        lettuce,
        tomato,
        onion,
        ketchup,
        mustard,
        pickle
    }

    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public decimal MealPrice { get; set; }

        public MenuItem()
        {

        }

        public MenuItem(int mealNumber, string mealName, string description, List<Ingredients>Ingredients, decimal mealPrice)
        {
            this.MealNumber = mealNumber;
            this.MealName = mealName;
            this.Description = description;
            this.Ingredients = Ingredients;
            this.MealPrice = mealPrice;
        }
    }
}
