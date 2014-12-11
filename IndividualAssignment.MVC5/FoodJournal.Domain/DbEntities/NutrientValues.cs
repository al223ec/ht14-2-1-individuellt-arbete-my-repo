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

        public int EnergyKj { get; set; }
        public int EnergyKcal { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }

        public int Carbohydrates { get; set; }
        public int Fibres { get; set; }
        public int Salt { get; set; }
        public int Ash { get; set; }
        public int Water { get; set; }
        public int Alcohol { get; set; }
        #region Carbohydrates
        public int Monosaccharides { get; set; }
        public int Disaccharides { get; set; }
        public int Saccharose { get; set; }
        public int Wholegrain { get; set; }
        #endregion
        #region FattyAcids
        public int SaturatedFattyAcids { get; set; }
        public int FattyAcid40100 { get; set; }
        public int FattyAcid120 { get; set; }
        public int FattyAcid140 { get; set; }
        public int FattyAcid160 { get; set; }
        public int FattyAcid180 { get; set; }
        public int FattyAcid200 { get; set; }
        public int MonounsaturatedFattyAcids { get; set; }
        public int FattyAcid161 { get; set; }
        public int FattyAcid181 { get; set; }
        public int SumPolyunsaturatedFattyAcids { get; set; }
        public int N6FattyAcids { get; set; }
        public int FattyAcid182 { get; set; }
        public int FattyAcid204 { get; set; }
        public int N3FattyAcids { get; set; }
        public int FattyAcid183 { get; set; }
        public int LongN3FattyAcids { get; set; }
        public int Epa { get; set; }
        public int Dpa { get; set; }
        public int Dha { get; set; }
        public int TransFattyAcids { get; set; }
        #endregion
        #region Cholesterol
        public int Cholesterol { get; set; }
        #endregion
        #region Fat-soluble  vitaminer
        public int RetinolEquivalents { get; set; }
        public int Retinol { get; set; }
        public int Betacarotene { get; set; }
        public int VitaminD { get; set; }
        public int VitaminE { get; set; }
        public int VitaminK { get; set; }
        #endregion
        #region Water-soluble vitamins
        public int Timamine { get; set; }
        public int Riboflavin { get; set; }
        public int VitaminC { get; set; }
        public int Niacin { get; set; }
        public int NiacinEquivalents { get; set; }
        public int VitaminB6 { get; set; }
        public int VitaminB12 { get; set; }
        public int Phosphorous { get; set; }
        public int Folate { get; set; }
        #endregion
        #region Minerals
        public int Iodine { get; set; }
        public int Trash { get; set; }
        public int Iron { get; set; }
        public int Calcium { get; set; }
        public int Potassium { get; set; }
        public int Magnesium { get; set; }
        public int Sodium { get; set; }
        public int Selenium { get; set; }
        public int Zink { get; set; }
        #endregion
    }
}
