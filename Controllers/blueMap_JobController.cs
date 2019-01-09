using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using pracMvc.Models;

namespace pracMvc.Controllers
{
    public class blueMap_JobController : Controller
    {
        private PUEntities db = new PUEntities();
        public ActionResult jsonList()
        {
            var j = db.blueMap_Job.ToList();
            return View();
        }
       
        // GET: blueMap_Job
        public ActionResult Index()
        {
            
            return View(db.blueMap_Job.ToList());
        }

        // GET: blueMap_Job/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blueMap_Job blueMap_Job = db.blueMap_Job.Find(id);
            if (blueMap_Job == null)
            {
                return HttpNotFound();
            }
            return View(blueMap_Job);
        }

        // GET: blueMap_Job/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: blueMap_Job/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "intID,schoolNo,CodeNo,grade,Name1,dataCount1,Ratio1,Name2,dataCount2,Ratio2,Name3,dataCount3,Ratio3,Name4,dataCount4,Ratio4,type,sort")] blueMap_Job blueMap_Job)
        {
            if (ModelState.IsValid)
            {
                db.blueMap_Job.Add(blueMap_Job);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blueMap_Job);
        }

        // GET: blueMap_Job/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blueMap_Job blueMap_Job = db.blueMap_Job.Find(id);
            if (blueMap_Job == null)
            {
                return HttpNotFound();
            }
            return View(blueMap_Job);
        }

        // POST: blueMap_Job/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "intID,schoolNo,CodeNo,grade,Name1,dataCount1,Ratio1,Name2,dataCount2,Ratio2,Name3,dataCount3,Ratio3,Name4,dataCount4,Ratio4,type,sort")] blueMap_Job blueMap_Job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blueMap_Job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blueMap_Job);
        }

        // GET: blueMap_Job/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blueMap_Job blueMap_Job = db.blueMap_Job.Find(id);
            if (blueMap_Job == null)
            {
                return HttpNotFound();
            }
            return View(blueMap_Job);
        }

        // POST: blueMap_Job/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            blueMap_Job blueMap_Job = db.blueMap_Job.Find(id);
            db.blueMap_Job.Remove(blueMap_Job);
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
