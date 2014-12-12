using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodJournal.Domain;
using FoodJournal.Domain.DAL;

namespace FoodJournal.Controllers
{
    public class FoodstuffsController : Controller
    {
        private FoodJournalContext db = new FoodJournalContext();

        // GET: Foodstuffs
        public ActionResult Index()
        {
            var foodstuffs = db.Foodstuffs.Include(f => f.NutrientValues);
            return View(foodstuffs.ToList());
        }

        // GET: Foodstuffs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Foodstuff foodstuff = db.Foodstuffs.Find(id);
            if (foodstuff == null)
            {
                return HttpNotFound();
            }
            return View(foodstuff);
        }

        // GET: Foodstuffs/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.NutrientValues, "FoodstuffID", "FoodstuffID");
            return View();
        }

        // POST: Foodstuffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Number")] Foodstuff foodstuff)
        {
            if (ModelState.IsValid)
            {
                db.Foodstuffs.Add(foodstuff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.NutrientValues, "FoodstuffID", "FoodstuffID", foodstuff.ID);
            return View(foodstuff);
        }

        // GET: Foodstuffs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Foodstuff foodstuff = db.Foodstuffs.Find(id);
            if (foodstuff == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.NutrientValues, "FoodstuffID", "FoodstuffID", foodstuff.ID);
            return View(foodstuff);
        }

        // POST: Foodstuffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Number")] Foodstuff foodstuff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodstuff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.NutrientValues, "FoodstuffID", "FoodstuffID", foodstuff.ID);
            return View(foodstuff);
        }

        // GET: Foodstuffs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Foodstuff foodstuff = db.Foodstuffs.Find(id);
            if (foodstuff == null)
            {
                return HttpNotFound();
            }
            return View(foodstuff);
        }

        // POST: Foodstuffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Foodstuff foodstuff = db.Foodstuffs.Find(id);
            db.Foodstuffs.Remove(foodstuff);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
