using FoodJournal.Domain.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodJournal.Controllers
{
    public class FoodJournalController : Controller
    {

        private FoodJournalContext db = new FoodJournalContext(); 
        // GET: FoodJournal
        public ActionResult Index()
        {
            var meals = db.Meals.ToList();
            return View(meals);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}