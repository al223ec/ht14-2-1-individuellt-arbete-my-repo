using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodJournal.Controllers
{
    public class FoodJournalController : Controller
    {
        // GET: FoodJournal
        public ActionResult Index()
        {
            return View();
        }
    }
}