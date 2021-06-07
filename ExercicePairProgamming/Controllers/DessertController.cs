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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DessertController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DessertController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DessertController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DessertController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
