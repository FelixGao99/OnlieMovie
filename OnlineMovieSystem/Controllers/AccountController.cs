using OnlineMovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineMovieSystem.Controllers
{
    public class AccountController : Controller
    {
        private MovieDB db = new MovieDB();

        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.Where(a => a.Account == model.Account).FirstOrDefault();

                if(user != null)
                {
                    if(user.Password == model.Password)
                    {
                        FormsAuthentication.SetAuthCookie(user.Account, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Message = "用户名密码错误";
                    }
                }
                else
                {
                    ViewBag.Message = "该用户不存在";
                }
            }

            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if(db.Users.Where(a => a.Account == model.Account).ToList().Count > 0)
                {
                    ViewBag.Message = "该用户已存在";
                }
                else
                {
                    User user = new User();
                    user.Account = model.Account;
                    user.Password = model.Password;
                    db.Users.Add(user);

                    if (db.SaveChanges() > 0)
                    {
                        ViewBag.Message = "注册成功";
                    }
                    else
                    {
                        ViewBag.Message = "注册失败";
                    }
                }
            }

            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }

    }
}