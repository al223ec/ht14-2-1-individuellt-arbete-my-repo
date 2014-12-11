using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodJournal.Domain
{
    public enum MealType{
        other, breakfast, lunch, dinner, snack
    }
    public partial class Meal
    {
        public int ID { get; set; }
        public MealType MealType { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Foodstuff> Foodstuffs { get; set; } 
    }
}