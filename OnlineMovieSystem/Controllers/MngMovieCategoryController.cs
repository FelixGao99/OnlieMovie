using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieSystem.Models;

namespace OnlineMovieSystem.Controllers
{
    public class MngMovieCategoryController : Controller
    {
        private MovieDB db = new MovieDB();

        // GET: MngMovieCategory
        public ActionResult Index()
        {
            return View(db.MovieCategories.ToList());
        }

        // GET: MngMovieCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieCategory movieCategory = db.MovieCategories.Find(id);
            if (movieCategory == null)
            {
                return HttpNotFound();
            }
            return View(movieCategory);
        }

        // GET: MngMovieCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MngMovieCategory/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] MovieCategory movieCategory)
        {
            if (ModelState.IsValid)
            {
                db.MovieCategories.Add(movieCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieCategory);
        }

        // GET: MngMovieCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieCategory movieCategory = db.MovieCategories.Find(id);
            if (movieCategory == null)
            {
                return HttpNotFound();
            }
            return View(movieCategory);
        }

        // POST: MngMovieCategory/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] MovieCategory movieCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieCategory);
        }

        // GET: MngMovieCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieCategory movieCategory = db.MovieCategories.Find(id);
            if (movieCategory == null)
            {
                return HttpNotFound();
            }
            return View(movieCategory);
        }

        // POST: MngMovieCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieCategory movieCategory = db.MovieCategories.Find(id);
            db.MovieCategories.Remove(movieCategory);
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
