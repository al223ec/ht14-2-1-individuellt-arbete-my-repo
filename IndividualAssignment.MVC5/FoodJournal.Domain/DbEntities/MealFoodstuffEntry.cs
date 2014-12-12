using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain
{
    public class MealFoodstuffEntry
    {
        public int ID { get; set; }
        public int MealID { get; set; }
        public int FoodstuffID { get; set; }
        //Vet inte riktigt varför jag har mealID och foodstuffID detta enligt http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-a-more-complex-data-model-for-an-asp-net-mvc-application
        public int Weight { get; set; }
        public virtual Meal Meal{ get; set; }
        public virtual Foodstuff Foodstuff{ get; set; }
    }
}
