using ExercicePairProgamming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Controllers
{
    public class DessertController : Controller
    {
        // GET: DessertController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DessertController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DessertController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DessertController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dessert dessert)
        {
            if (ModelState.IsValid)
            {
                dessert = new DessertRepository().AddOneBurger(dessert);

                if (dessert == null)
                    TempData["MessageAjout"] = "Erreur";
                else
                    TempData["MessageAjout"] = "Le dessert est ajouté";
                return View("CreateDessert");

            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: DessertController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DessertController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Dessert dessert)
        {
            if (ModelState.IsValid)
            {
                dessert = new DessertRepository().EditDessert(dessert);

                if (dessert != null)
                {
                    ViewBag.Message = "Modification validée";
                    return View(dessert);
                }

                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: DessertController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DessertController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Dessert dessert)
        {
            dessert = new DessertRepository().DelOneDessert(id);

            if (dessert == null)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Index");
        }
    }
}
