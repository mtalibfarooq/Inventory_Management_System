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
    public class PRODUCT_DETAILSController : Controller
    {
        private Inventory_Management_SystemEntities db = new Inventory_Management_SystemEntities();

        // GET: PRODUCT_DETAILS
        public ActionResult Index()
        {
            var pRODUCT_DETAILS = db.PRODUCT_DETAILS.Include(p => p.PRODUCT);
            return View(pRODUCT_DETAILS.ToList());
        }

        // GET: PRODUCT_DETAILS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_DETAILS pRODUCT_DETAILS = db.PRODUCT_DETAILS.Find(id);
            if (pRODUCT_DETAILS == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT_DETAILS);
        }

        // GET: PRODUCT_DETAILS/Create
        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(db.PRODUCTs, "Product_ID", "Product_Name");
            return View();
        }

        // POST: PRODUCT_DETAILS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Product_Quantity,Product_Price,ProductID")] PRODUCT_DETAILS pRODUCT_DETAILS)
        {
            if (ModelState.IsValid)
            {
                pRODUCT_DETAILS.CreatedDate = DateTime.Now;
                pRODUCT_DETAILS.CreatedBy = Convert.ToInt32(Session["id"]);
                pRODUCT_DETAILS.Product_Sold = 0;
                pRODUCT_DETAILS.Product_Avaliable = pRODUCT_DETAILS.Product_Quantity;
                
                db.PRODUCT_DETAILS.Add(pRODUCT_DETAILS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductID = new SelectList(db.PRODUCTs, "Product_ID", "Product_Name", pRODUCT_DETAILS.ProductID);
            return View(pRODUCT_DETAILS);
        }

        // GET: PRODUCT_DETAILS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_DETAILS pRODUCT_DETAILS = db.PRODUCT_DETAILS.Find(id);
            if (pRODUCT_DETAILS == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductID = new SelectList(db.PRODUCTs, "Product_ID", "Product_Name", pRODUCT_DETAILS.ProductID);
            return View(pRODUCT_DETAILS);
        }

        // POST: PRODUCT_DETAILS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Product_Detail_ID,Product_Quantity,Product_Price,Product_Sold,Product_Avaliable,CreatedDate,UpdatedDate,CreatedBy,UpdatedBy,ProductID")] PRODUCT_DETAILS pRODUCT_DETAILS)
        {
            if (ModelState.IsValid)
            {
                var oldInfo = db.PRODUCT_DETAILS.Find(pRODUCT_DETAILS.Product_Detail_ID);
                oldInfo.Product_Quantity = pRODUCT_DETAILS.Product_Quantity;
                oldInfo.Product_Price = pRODUCT_DETAILS.Product_Price;
                oldInfo.Product_Sold = pRODUCT_DETAILS.Product_Sold;
                oldInfo.Product_Avaliable = pRODUCT_DETAILS.Product_Avaliable;
                oldInfo.ProductID = pRODUCT_DETAILS.ProductID;
                oldInfo.UpdatedDate = DateTime.Now;
                oldInfo.UpdatedBy = Convert.ToInt32(Session["id"]);
                db.Entry(oldInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(db.PRODUCTs, "Product_ID", "Product_Name", pRODUCT_DETAILS.ProductID);
            return View(pRODUCT_DETAILS);
        }

        // GET: PRODUCT_DETAILS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_DETAILS pRODUCT_DETAILS = db.PRODUCT_DETAILS.Find(id);
            if (pRODUCT_DETAILS == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT_DETAILS);
        }

        // POST: PRODUCT_DETAILS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUCT_DETAILS pRODUCT_DETAILS = db.PRODUCT_DETAILS.Find(id);
            db.PRODUCT_DETAILS.Remove(pRODUCT_DETAILS);
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
