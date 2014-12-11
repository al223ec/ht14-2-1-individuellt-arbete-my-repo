using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodJournal.ViewModels
{
    public class MealFoodstuffData
    {
        public int FoodstuffID { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}