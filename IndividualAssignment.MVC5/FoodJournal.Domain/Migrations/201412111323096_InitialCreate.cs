namespace FoodJournal.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foodstuff",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Meal",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MealType = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NutrientValues",
                c => new
                    {
                        FoodstuffID = c.Int(nullable: false),
                        EnergyKj = c.Int(nullable: false),
                        EnergyKcal = c.Int(nullable: false),
                        Protein = c.Int(nullable: false),
                        Fat = c.Int(nullable: false),
                        Carbohydrates = c.Int(nullable: false),
                        Fibres = c.Int(nullable: false),
                        Salt = c.Int(nullable: false),
                        Ash = c.Int(nullable: false),
                        Water = c.Int(nullable: false),
                        Alcohol = c.Int(nullable: false),
                        Monosaccharides = c.Int(nullable: false),
                        Disaccharides = c.Int(nullable: false),
                        Saccharose = c.Int(nullable: false),
                        Wholegrain = c.Int(nullable: false),
                        SaturatedFattyAcids = c.Int(nullable: false),
                        FattyAcid40100 = c.Int(nullable: false),
                        FattyAcid120 = c.Int(nullable: false),
                        FattyAcid140 = c.Int(nullable: false),
                        FattyAcid160 = c.Int(nullable: false),
                        FattyAcid180 = c.Int(nullable: false),
                        FattyAcid200 = c.Int(nullable: false),
                        MonounsaturatedFattyAcids = c.Int(nullable: false),
                        FattyAcid161 = c.Int(nullable: false),
                        FattyAcid181 = c.Int(nullable: false),
                        SumPolyunsaturatedFattyAcids = c.Int(nullable: false),
                        N6FattyAcids = c.Int(nullable: false),
                        FattyAcid182 = c.Int(nullable: false),
                        FattyAcid204 = c.Int(nullable: false),
                        N3FattyAcids = c.Int(nullable: false),
                        FattyAcid183 = c.Int(nullable: false),
                        LongN3FattyAcids = c.Int(nullable: false),
                        Epa = c.Int(nullable: false),
                        Dpa = c.Int(nullable: false),
                        Dha = c.Int(nullable: false),
                        TransFattyAcids = c.Int(nullable: false),
                        Cholesterol = c.Int(nullable: false),
                        RetinolEquivalents = c.Int(nullable: false),
                        Retinol = c.Int(nullable: false),
                        Betacarotene = c.Int(nullable: false),
                        VitaminD = c.Int(nullable: false),
                        VitaminE = c.Int(nullable: false),
                        VitaminK = c.Int(nullable: false),
                        Timamine = c.Int(nullable: false),
                        Riboflavin = c.Int(nullable: false),
                        VitaminC = c.Int(nullable: false),
                        Niacin = c.Int(nullable: false),
                        NiacinEquivalents = c.Int(nullable: false),
                        VitaminB6 = c.Int(nullable: false),
                        VitaminB12 = c.Int(nullable: false),
                        Phosphorous = c.Int(nullable: false),
                        Folate = c.Int(nullable: false),
                        Iodine = c.Int(nullable: false),
                        Trash = c.Int(nullable: false),
                        Iron = c.Int(nullable: false),
                        Calcium = c.Int(nullable: false),
                        Potassium = c.Int(nullable: false),
                        Magnesium = c.Int(nullable: false),
                        Sodium = c.Int(nullable: false),
                        Selenium = c.Int(nullable: false),
                        Zink = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodstuffID)
                .ForeignKey("dbo.Foodstuff", t => t.FoodstuffID)
                .Index(t => t.FoodstuffID);
            
            CreateTable(
                "dbo.MealFoodstuff",
                c => new
                    {
                        Meal_ID = c.Int(nullable: false),
                        Foodstuff_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Meal_ID, t.Foodstuff_ID })
                .ForeignKey("dbo.Meal", t => t.Meal_ID, cascadeDelete: true)
                .ForeignKey("dbo.Foodstuff", t => t.Foodstuff_ID, cascadeDelete: true)
                .Index(t => t.Meal_ID)
                .Index(t => t.Foodstuff_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NutrientValues", "FoodstuffID", "dbo.Foodstuff");
            DropForeignKey("dbo.MealFoodstuff", "Foodstuff_ID", "dbo.Foodstuff");
            DropForeignKey("dbo.MealFoodstuff", "Meal_ID", "dbo.Meal");
            DropIndex("dbo.MealFoodstuff", new[] { "Foodstuff_ID" });
            DropIndex("dbo.MealFoodstuff", new[] { "Meal_ID" });
            DropIndex("dbo.NutrientValues", new[] { "FoodstuffID" });
            DropTable("dbo.MealFoodstuff");
            DropTable("dbo.NutrientValues");
            DropTable("dbo.Meal");
            DropTable("dbo.Foodstuff");
        }
    }
}
