using ExercicePairProgamming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBurger.Repositories;

namespace ExercicePairProgamming.Controllers
{
    public class BurgerController : Controller
    {
        // GET: BurgerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BurgerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BurgerController/Create 
        public ActionResult Create()
        {
            return View();
        }

        // POST: BurgerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Burger burger)
        {
            if (ModelState.IsValid)
            {
                burger = new BurgerRepository().AddBurger(burger);

                if (burger == null)
                    TempData["MessageAjout"] = "Erreur";
                else
                    TempData["MessageAjout"] = "Le burger est ajouté";
                return View("CreateBurger");

            }
            else
                return RedirectToAction("Index", "Home");   
        }

        // GET: BurgerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BurgerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Burger burger)
        {
            if (ModelState.IsValid)
            {
                burger = new BurgerRepository().EditBurger(burger);

                if (burger != null)
                {
                    ViewBag.Message = "Modification validée";
                    return View(burger);
                }

                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: BurgerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BurgerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Burger burger)
        {
            burger = new BurgerRepository().DelOneBurger(id);

            if (burger == null)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Index");
        }
    }
}
