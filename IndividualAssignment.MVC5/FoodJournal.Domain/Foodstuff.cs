using System;
﻿using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain
{
    public partial class Foodstuff
    {
        public Foodstuff()
        { }
        public Foodstuff(JToken foodstuffToken)
        {
            Name = foodstuffToken.Value<string>("name");
            Number = int.Parse(foodstuffToken.Value<string>("number"));
        }
    }
}
