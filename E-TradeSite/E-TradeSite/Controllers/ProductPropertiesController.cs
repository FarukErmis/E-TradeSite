using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_Trade.DAL.Context;
using E_Trade.Model.Entity;

namespace E_TradeSite.Controllers
{
    public class ProductPropertiesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: ProductProperties
        public ActionResult Index()
        {
            var productProperties = db.ProductProperties.Include(p => p.Product);
            return View(productProperties.ToList());
        }

        // GET: ProductProperties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductProperty productProperty = db.ProductProperties.Find(id);
            if (productProperty == null)
            {
                return HttpNotFound();
            }
            return View(productProperty);
        }

        // GET: ProductProperties/Create
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProuductName");
            return View();
        }

        // POST: ProductProperties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductId,VarKey,VarValue,CategoryId")] ProductProperty productProperty)
        {
            if (ModelState.IsValid)
            {
                db.ProductProperties.Add(productProperty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProuductName", productProperty.ProductId);
            return View(productProperty);
        }

        // GET: ProductProperties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductProperty productProperty = db.ProductProperties.Find(id);
            if (productProperty == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProuductName", productProperty.ProductId);
            return View(productProperty);
        }

        // POST: ProductProperties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProductId,VarKey,VarValue,CategoryId")] ProductProperty productProperty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productProperty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProuductName", productProperty.ProductId);
            return View(productProperty);
        }

        // GET: ProductProperties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductProperty productProperty = db.ProductProperties.Find(id);
            if (productProperty == null)
            {
                return HttpNotFound();
            }
            return View(productProperty);
        }

        // POST: ProductProperties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductProperty productProperty = db.ProductProperties.Find(id);
            db.ProductProperties.Remove(productProperty);
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
