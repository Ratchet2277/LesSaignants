using ExercicePairProgamming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Controllers
{
    public class SideController : Controller
    {
        // GET: SideController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SideController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SideController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SideController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Side side)
        {
            if (ModelState.IsValid)
            {
                side = new SideRepository().AddOneSide(side);

                if (side == null)
                    TempData["MessageAjout"] = "Erreur";
                else
                    TempData["MessageAjout"] = "Le side est ajouté";
                return View("CreateSide");

            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: SideController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SideController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Side side)
        {
            if (ModelState.IsValid)
            {
                side = new SideRepository().EditSide(side);

                if (side != null)
                {
                    ViewBag.Message = "Modification validée";
                    return View(side);
                }

                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: SideController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SideController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Side side)
        {
            side = new SideRepository().DelOneSide(id);

            if (side == null)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Index");
        }
    }
}
