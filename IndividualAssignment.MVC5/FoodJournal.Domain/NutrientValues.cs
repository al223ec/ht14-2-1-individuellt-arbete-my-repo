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
}
