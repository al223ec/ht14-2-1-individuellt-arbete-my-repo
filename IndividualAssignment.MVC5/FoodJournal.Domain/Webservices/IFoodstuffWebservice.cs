using System;
using System.Collections.Generic;
namespace FoodJournal.Domain.Webservices
{
    public interface IFoodstuffWebservice
    {
        IEnumerable<Foodstuff> GetFoodstuff();
        IEnumerable<Foodstuff> GetFoodstuff(int number);
        NutrientValues GetNutrientValues(int number); 
    }
}
