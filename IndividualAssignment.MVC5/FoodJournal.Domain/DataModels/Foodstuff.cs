using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain
{
    public partial class Foodstuff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public virtual NutrientValues NutrientValues { get; set; }
        
    }
}
