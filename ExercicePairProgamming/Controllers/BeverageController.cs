using ExercicePairProgamming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Controllers
{
    public class BeverageController : Controller
    {
        // GET: BeverageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BeverageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BeverageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeverageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Beverage beverage)
        {
            if (ModelState.IsValid)
            {
                beverage = new BeverageRepository().AddOneBeverage(beverage);

                if (beverage == null)
                    TempData["MessageAjout"] = "Erreur";
                else
                    TempData["MessageAjout"] = "Le beverage est ajouté";
                return View("CreateBeverage");

            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: BeverageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BeverageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Beverage beverage)
        {
            if (ModelState.IsValid)
            {
                beverage = new BeverageRepository().EditBeverage(beverage);

                if (beverage != null)
                {
                    ViewBag.Message = "Modification validée";
                    return View(beverage);
                }

                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: BeverageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BeverageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Beverage beverage)
        {
            beverage = new BeverageRepository().DelOneBeverage(id);

            if (beverage == null)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Index");
        }
    }
}
