using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain
{
    public partial class NutrientValues
    {
        [Key]
        [ForeignKey("Foodstuff")]
        public int FoodstuffID { get; set; }
        public virtual Foodstuff Foodstuff { get; set; }

        public decimal EnergyKj { get; set; }
        public decimal EnergyKcal { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }

        public decimal Carbohydrates { get; set; }
        public decimal Fibres { get; set; }
        public decimal Salt { get; set; }
        public decimal Ash { get; set; }
        public decimal Water { get; set; }
        public decimal Alcohol { get; set; }
        #region Carbohydrates
        public decimal Monosaccharides { get; set; }
        public decimal Disaccharides { get; set; }
        public decimal Saccharose { get; set; }
        public decimal Wholegrain { get; set; }
        #endregion
        #region FattyAcids
        public decimal SaturatedFattyAcids { get; set; }
        public decimal FattyAcid40100 { get; set; }
        public decimal FattyAcid120 { get; set; }
        public decimal FattyAcid140 { get; set; }
        public decimal FattyAcid160 { get; set; }
        public decimal FattyAcid180 { get; set; }
        public decimal FattyAcid200 { get; set; }
        public decimal MonounsaturatedFattyAcids { get; set; }
        public decimal FattyAcid161 { get; set; }
        public decimal FattyAcid181 { get; set; }
        public decimal SumPolyunsaturatedFattyAcids { get; set; }
        public decimal N6FattyAcids { get; set; }
        public decimal FattyAcid182 { get; set; }
        public decimal FattyAcid204 { get; set; }
        public decimal N3FattyAcids { get; set; }
        public decimal FattyAcid183 { get; set; }
        public decimal LongN3FattyAcids { get; set; }
        public decimal Epa { get; set; }
        public decimal Dpa { get; set; }
        public decimal Dha { get; set; }
        public decimal TransFattyAcids { get; set; }
        #endregion
        #region Cholesterol
        public decimal Cholesterol { get; set; }
        #endregion
        #region Fat-soluble  vitaminer
        public decimal RetinolEquivalents { get; set; }
        public decimal Retinol { get; set; }
        public decimal Betacarotene { get; set; }
        public decimal VitaminD { get; set; }
        public decimal VitaminE { get; set; }
        public decimal VitaminK { get; set; }
        #endregion
        #region Water-soluble vitamins
        public decimal Timamine { get; set; }
        public decimal Riboflavin { get; set; }
        public decimal VitaminC { get; set; }
        public decimal Niacin { get; set; }
        public decimal NiacinEquivalents { get; set; }
        public decimal VitaminB6 { get; set; }
        public decimal VitaminB12 { get; set; }
        public decimal Phosphorous { get; set; }
        public decimal Folate { get; set; }
        #endregion
        #region Minerals
        public decimal Iodine { get; set; }
        public decimal Trash { get; set; }
        public decimal Iron { get; set; }
        public decimal Calcium { get; set; }
        public decimal Potassium { get; set; }
        public decimal Magnesium { get; set; }
        public decimal Sodium { get; set; }
        public decimal Selenium { get; set; }
        public decimal Zink { get; set; }
        #endregion
    }
}
