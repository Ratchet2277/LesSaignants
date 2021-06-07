using ExercicePairProgamming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product produc)
        {
            if (ModelState.IsValid)
            {
                produc = new ProductRepository().AddOneProduct(produc);

                if (produc == null)
                    TempData["MessageAjout"] = "Erreur";
                else
                    TempData["MessageAjout"] = "Le produc est ajouté";
                return View("CreateProduct");

            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                product = new ProductRepository().EditProduct(product);

                if (product != null)
                {
                    ViewBag.Message = "Modification validée";
                    return View(product);
                }

                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
        {
            product = new ProductRepository().DelOneProduct(id);

            if (product == null)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Index");
        }
    }
}
