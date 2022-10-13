using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Oct07.Models;

namespace Oct07.Controllers
{
    public class Issue_Controller : Controller
    {
        private libraryEntities db = new libraryEntities();

        // GET: Issue_
        public ActionResult Index()
        {
            var issue_C = db.Issue_C.Include(i => i.Book_C).Include(i => i.Member_C);
            return View(issue_C.ToList());
        }

        // GET: Issue_/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue_C issue_C = db.Issue_C.Find(id);
            if (issue_C == null)
            {
                return HttpNotFound();
            }
            return View(issue_C);
        }

        // GET: Issue_/Create
        public ActionResult Create()
        {
            ViewBag.Book_No = new SelectList(db.Book_C, "Book_No", "Book_Name");
            ViewBag.Member_Id = new SelectList(db.Member_C, "Member_Id", "Member_Id");
            return View();
        }

        // POST: Issue_/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Lib_Issue_Id,Member_Id,Book_No,Issue_Date,Return_Date")] Issue_C issue_C)
        {
            if (ModelState.IsValid)
            {
                db.Issue_C.Add(issue_C);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Book_No = new SelectList(db.Book_C, "Book_No", "Book_Name", issue_C.Book_No);
            ViewBag.Member_Id = new SelectList(db.Member_C, "Member_Id", "Member_Id", issue_C.Member_Id);
            return View(issue_C);
        }

        // GET: Issue_/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue_C issue_C = db.Issue_C.Find(id);
            if (issue_C == null)
            {
                return HttpNotFound();
            }
            ViewBag.Book_No = new SelectList(db.Book_C, "Book_No", "Book_Name", issue_C.Book_No);
            ViewBag.Member_Id = new SelectList(db.Member_C, "Member_Id", "Member_Id", issue_C.Member_Id);
            return View(issue_C);
        }

        // POST: Issue_/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Lib_Issue_Id,Member_Id,Book_No,Issue_Date,Return_Date")] Issue_C issue_C)
        {
            if (ModelState.IsValid)
            {
                db.Entry(issue_C).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Book_No = new SelectList(db.Book_C, "Book_No", "Book_Name", issue_C.Book_No);
            ViewBag.Member_Id = new SelectList(db.Member_C, "Member_Id", "Member_Id", issue_C.Member_Id);
            return View(issue_C);
        }

        // GET: Issue_/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue_C issue_C = db.Issue_C.Find(id);
            if (issue_C == null)
            {
                return HttpNotFound();
            }
            return View(issue_C);
        }

        // POST: Issue_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            Issue_C issue_C = db.Issue_C.Find(id);
            db.Issue_C.Remove(issue_C);
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
