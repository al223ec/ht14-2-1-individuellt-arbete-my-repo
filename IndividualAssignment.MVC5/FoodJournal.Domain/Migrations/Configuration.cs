namespace FoodJournal.Domain.Migrations
{
    using FoodJournal.Domain.DAL;
    using FoodJournal.Domain.Webservices;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodJournalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //tillåter att man dropar data, detta bör sättas till true om man kör Update-Database 
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "FoodJournal.Domain.DAL.FoodJournalContext";
        }

        protected override void Seed(FoodJournalContext context)
        {
            FoodstuffWebservice _service = new FoodstuffWebservice();
            var foodstuffs = _service.GetFoodstuff();
            foodstuffs.ToList().ForEach(f => context.Foodstuffs.Add(f));

            context.SaveChanges(); 

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
