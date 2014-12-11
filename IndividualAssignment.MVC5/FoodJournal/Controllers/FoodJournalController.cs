using FoodJournal.Domain;
using FoodJournal.Domain.DAL;
using FoodJournal.ViewModels;
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
            PopulateMealFoodstuffData(new Meal()); 
            return View(new List<Meal>());
        }

        // GET: FoodJournal/Create
        public ActionResult Create()
        {
            Meal meal = new Meal();
            meal.Foodstuffs = new List<Foodstuff>();
            PopulateMealFoodstuffData(meal); 

            return View();
        }

        private void PopulateMealFoodstuffData(Meal meal)
        {
            var allFoodstuffs = db.Foodstuffs;
            //var mealFoodstuffs = new HashSet<int>(meal.Foodstuffs.Select(f => f.ID));
            var viewModel = new List<MealFoodstuffData>();

            foreach (var foodstuff in allFoodstuffs)
            {
                viewModel.Add(new MealFoodstuffData
                {
                    FoodstuffID = foodstuff.ID,
                    Name = foodstuff.Name,
                });
            }
            ViewBag.Foodstuffs = viewModel;
        }

        // POST: FoodJournal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Time, Foodstuffs")]Meal meal)
        {
            try
            {
                if (ModelState.IsValid)
                {
//                    _repository.Add(contact);
//                   _repository.Save();
                    TempData["success"] = "Kontakten har sparats.";
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}