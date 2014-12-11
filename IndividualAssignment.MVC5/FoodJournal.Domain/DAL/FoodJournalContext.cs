using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FoodJournal.Domain.DAL
{
    public class FoodJournalContext : DbContext
    {
        public FoodJournalContext()
            : base("FoodJournalContext")
        { }
        public DbSet<Foodstuff> Foodstuffs { get; set; }
        public DbSet<NutrientValues> NutrientValues { get; set; }

        public DbSet<Meal> Meals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
