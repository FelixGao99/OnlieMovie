using OnlineMovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMovieSystem.Controllers
{
    // 首页控制器
    public class HomeController : Controller
    {
        private MovieDB db = new MovieDB();

        public ActionResult Index()
        {
            ViewBag.MoviesInShow = db.Movies.Where(m => m.ReleaseTime <= DateTime.Today).ToList();
            ViewBag.MoviesNotShow = db.Movies.Where(m => m.ReleaseTime > DateTime.Today).ToList();
            ViewBag.MoviesRecommend = db.Movies.OrderByDescending(m => m.LikeNum).ToList().Take(4);

            return View();
        }
    }
}