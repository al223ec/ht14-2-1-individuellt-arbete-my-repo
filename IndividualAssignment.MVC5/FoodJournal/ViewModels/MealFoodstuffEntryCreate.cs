using FoodJournal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodJournal.ViewModels
{
    public class MealFoodstuffEntryCreate
    {
        public int Weight { get; set; }
        public string FoodstuffName { get; set; }
        public IEnumerable<Foodstuff> Foodstuffs { get; set; }
        public ICollection<Foodstuff> SelectedFoodstuffs { get; set; }
        public Meal Meal { get; set; }
    }
}