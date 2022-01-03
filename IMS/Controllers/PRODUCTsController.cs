using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IMS;

namespace IMS.Controllers
{
    public class PRODUCTsController : Controller
    {
        private Inventory_Management_SystemEntities db = new Inventory_Management_SystemEntities();

        // GET: PRODUCTs
        public ActionResult Index()
        {
            var pRODUCTs = db.PRODUCTs.Include(p => p.CATEGORY);
            return View(pRODUCTs.ToList());
        }

        // GET: PRODUCTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT pRODUCT = db.PRODUCTs.Find(id);
            if (pRODUCT == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT);
        }

        // GET: PRODUCTs/Create
        public ActionResult Create()
        {
            ViewBag.Category_Id = new SelectList(db.CATEGORies, "Category_ID", "Category_Name");
            return View();
        }

        // POST: PRODUCTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Product_Name,Category_Id")] PRODUCT pRODUCT)
        {
            if (ModelState.IsValid)
            {
                pRODUCT.CreatedDate = DateTime.Now;
                db.PRODUCTs.Add(pRODUCT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category_Id = new SelectList(db.CATEGORies, "Category_ID", "Category_Name", pRODUCT.Category_Id);
            return View(pRODUCT);
        }

        // GET: PRODUCTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT pRODUCT = db.PRODUCTs.Find(id);
            if (pRODUCT == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category_Id = new SelectList(db.CATEGORies, "Category_ID", "Category_Name", pRODUCT.Category_Id);
            return View(pRODUCT);
        }

        // POST: PRODUCTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Product_ID,Product_Name,Category_Id")] PRODUCT pRODUCT)
        {
            if (ModelState.IsValid)
            {
                var oldInfo = db.PRODUCTs.Find(pRODUCT.Product_ID);
                oldInfo.Product_Name = pRODUCT.Product_Name;
                oldInfo.UpdatedDate = DateTime.Now;
                oldInfo.Category_Id = pRODUCT.Category_Id;
                db.Entry(oldInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category_Id = new SelectList(db.CATEGORies, "Category_ID", "Category_Name", pRODUCT.Category_Id);
            return View(pRODUCT);
        }

        // GET: PRODUCTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT pRODUCT = db.PRODUCTs.Find(id);
            if (pRODUCT == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT);
        }

        // POST: PRODUCTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUCT pRODUCT = db.PRODUCTs.Find(id);
            db.PRODUCTs.Remove(pRODUCT);
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
