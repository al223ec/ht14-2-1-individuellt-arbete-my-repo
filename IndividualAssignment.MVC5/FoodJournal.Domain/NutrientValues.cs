using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain
{
    public partial class NutrientValues
    {
         public NutrientValues()
        { }
         public NutrientValues(JToken nutrientValuesToken)
        {
            if (nutrientValuesToken != null)
            {
                NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
                foreach (var prop in this.GetType().GetProperties())
                {
                    PropertyInfo propInfo = this.GetType().GetProperty(prop.Name, BindingFlags.Public | BindingFlags.Instance);
                    decimal num = 0;
                    var stringKey = Char.ToLowerInvariant(prop.Name[0]) + prop.Name.Substring(1);
                    if (null != propInfo && propInfo.CanWrite && decimal.TryParse(nutrientValuesToken.Value<string>(stringKey), style, CultureInfo.InvariantCulture, out num))
                    {
                        propInfo.SetValue(this, num);
                    }
                }
            }
        }
    }
 /*
 * Exempel förväntat data
 * "nutrientValues":{
  *     "energyKj":695,"energyKcal":166,"protein":5.9,"fat":7.5,
 *      "carbohydrates":17.2,"fibres":2.9,"salt":0.8,"ash":1.4,"water":65.1,"alcohol":0,
 *      "monosaccharides":1.9,"disaccharides":1.3,"saccharose":0,"wholegrain":0,"saturatedFattyAcids":3.6,
 *      "fattyAcid40100":0.2,"fattyAcid120":0.1,"fattyAcid140":0.4,"fattyAcid160":1.9,"fattyAcid180":0.9,
 *      "fattyAcid200":0,"monounsaturatedFattyAcids":2.7,"fattyAcid161":0.1,"fattyAcid181":2.5,
 *      "sumPolyunsaturatedFattyAcids":0.6,"fattyAcid182":0.5,"fattyAcid204":0,"fattyAcid183":0.1,
 *      "longN3FattyAcids":0,"epa":0,"dpa":0,"dha":0,"cholesterol":15.7,"retinolEquivalents":19,
 *      "retinol":14,"betacarotene":64,"vitaminD":0.1,"vitaminE":0.32,"vitaminK":3,"thiamine":0.08,
 *      "riboflavin":0.07,"vitaminC":3,"niacin":1,"niacinEquivalents":2.4,"vitaminB6":0.1,"vitaminB12":0.21,
 *      "phosphorous":58,"folate":16,"iodine":12,"trash":0,"iron":0.82,"calcium":43,"potassium":146,"magnesium":13,
 *      "sodium":328,"selenium":2.1,"zink":0.48
  *      }
 */
}
