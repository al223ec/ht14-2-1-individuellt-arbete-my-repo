using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain
{
    public interface IFoodJournalService : IDisposable
    {
        IEnumerable<string> GetFoodstuffNames(string term);

        IEnumerable<string> GetFoodstuffNames(); 

        IEnumerable<Foodstuff> GetFoodstuff();

        NutrientValues GetNutrientValues(Foodstuff foodstuff);

        void SaveMeal(Meal meal); 

    }
}
