using FoodJournal.Domain;
using FoodJournal.Domain.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodJournal.Controllers
{
    public class HomeController : Controller
    {
        private FoodJournalContext db = new FoodJournalContext(); 
        public ActionResult Index()
        {
            var result = db.Foodstuffs.ToList(); 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}