using ExercicePairProgamming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Controllers
{
    public class MenuController : Controller
    {
        // GET: MenuController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Menu menu)
        {
            if (ModelState.IsValid)
            {
                menu = new MenuRepository().AddOneMenu(menu);

                if (menu == null)
                    TempData["MessageAjout"] = "Erreur";
                else
                    TempData["MessageAjout"] = "Le menu est ajouté";
                return View("CreateMenu");

            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Menu menu)
        {
            if (ModelState.IsValid)
            {
                menu = new MenuRepository().EditMenu(menu);

                if (menu != null)
                {
                    ViewBag.Message = "Modification validée";
                    return View(menu);
                }

                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Menu menu)
        {
            menu = new MenuRepository().DelOneMenu(id);

            if (menu == null)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Index");
        }
    }
}
