using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal.Domain.Webservices
{
    public class FoodstuffWebservice : IFoodstuffWebservice
    {
        public IEnumerable<Foodstuff> GetFoodstuff()
        {
            var rawJson = string.Empty;
            
            var requestUriString = String.Format("http://www.matapi.se/foodstuff");
            var request = (HttpWebRequest)WebRequest.Create(requestUriString);
            
            using (var response = request.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawJson = reader.ReadToEnd();
            }

            return JArray.Parse(rawJson).Select(t => new Foodstuff(t)).ToList();
        }
        public IEnumerable<Foodstuff> GetFoodstuff(int number)
        {
            throw new NotImplementedException();
        }
    }
}
