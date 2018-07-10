using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCpractice2.Models;

namespace MVCpractice2.Controllers
{
    public class VitrualPetsController : Controller
    {
        private MVCpractice2Context db = new MVCpractice2Context();

        // GET: VitrualPets
        public ActionResult Index()
        {
            return View(db.VitrualPets.ToList());
        }

        // GET: VitrualPets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VitrualPet vitrualPet = db.VitrualPets.Find(id);
            if (vitrualPet == null)
            {
                return HttpNotFound();
            }
            return View(vitrualPet);
        }

        // GET: VitrualPets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VitrualPets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VituralPetID,Name,Age,Hunger,Type,Thrist")] VitrualPet vitrualPet)
        {
            if (ModelState.IsValid)
            {
                db.VitrualPets.Add(vitrualPet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vitrualPet);
        }

        // GET: VitrualPets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VitrualPet vitrualPet = db.VitrualPets.Find(id);
            if (vitrualPet == null)
            {
                return HttpNotFound();
            }
            return View(vitrualPet);
        }

        // POST: VitrualPets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VituralPetID,Name,Age,Hunger,Type,Thrist")] VitrualPet vitrualPet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vitrualPet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vitrualPet);
        }

        // GET: VitrualPets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VitrualPet vitrualPet = db.VitrualPets.Find(id);
            if (vitrualPet == null)
            {
                return HttpNotFound();
            }
            return View(vitrualPet);
        }

        // POST: VitrualPets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VitrualPet vitrualPet = db.VitrualPets.Find(id);
            db.VitrualPets.Remove(vitrualPet);
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
