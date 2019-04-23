using Newtonsoft.Json.Linq;
using OnlineMovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineMovieSystem.Controllers
{
    public class MovieController : Controller
    {
        private MovieDB db = new MovieDB();

        // 电影列表
        public ActionResult Index(string keyword)
        {
            ViewBag.MovieCategories = db.MovieCategories.ToList();

            // 关键字搜索
            if (!string.IsNullOrEmpty(keyword))
            {
                ViewBag.Movies = db.Movies.Where(m => m.CnName.Contains(keyword)).ToList();
            }
            else
            {
                ViewBag.Movies = db.Movies.ToList();
            }

            return View();
        }

        // 电影详情
        public ActionResult Detail(int? id)
        {
            Movie movie_item = db.Movies.Find(id);

            return View(movie_item);
        }

        // 点赞
        public JObject SetLikeNum(int id)
        {
            var movie = db.Movies.Find(id);
            movie.LikeNum += 1;

            JObject rv = new JObject();

            if (db.SaveChanges() > 0)
            {
                rv["flag"] = true;
                rv["msg"] = "点赞成功！";
            }
            else
            {
                rv["flag"] = false;
                rv["msg"] = "点赞成功！";
            }

            return rv;
        }

        // 发表评论
        [HttpPost]
        public JObject SetComment(int id, string comment)
        {
            var current_user = User.Identity.Name;
            var movie = db.Movies.Find(id);
            var user = db.Users.Where(a => a.Account == User.Identity.Name).FirstOrDefault();

            JObject rv = new JObject();

            MovieComment newComment = new MovieComment();
            newComment.CreateDate = DateTime.Now;
            newComment.Content = comment;
            newComment.LikeNum = 0;
            newComment.user = user;
            newComment.userId = user.ID;
            newComment.movie = movie;
            newComment.movieId = movie.ID;
            db.MovieComments.Add(newComment);
            
            if(db.SaveChanges() > 0)
            {
                rv["flag"] = true;
                rv["msg"] = "发表成功！";
            }
            else
            {
                rv["flag"] = false;
                rv["msg"] = "发表失败！";
            }

            return rv;
        }

    }
}