using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain.DAL
{
    public class FoodJournalInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<FoodJournalContext>
    {
        protected override void Seed(FoodJournalContext context)
        {        
            FoodstuffWebservice _service = new FoodstuffWebservice();
            var foodstuffs = _service.GetFoodstuff();
            foodstuffs.ToList().ForEach(f => context.Foodstuffs.Add(f));
            context.SaveChanges(); 
        }
    }
}
