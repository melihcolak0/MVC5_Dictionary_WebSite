using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    [AllowAnonymous]
    public class LogInController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        // GET: LogIn

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var user = adminManager.GetUser(p);
            
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.AdminUserName, false);
                Session["AdminUserName"] = user.AdminUserName;

                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                ViewBag.ErrorMessage = "Hatalı kullanıcı adı veya şifre!";
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("Index");
        }

        [HttpGet]        
        public ActionResult WriterLogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WriterLogIn(Writer p)
        {
            var writer = writerManager.GetWriter(p);

            if(writer != null)
            {
                FormsAuthentication.SetAuthCookie(writer.WriterMail, false);
                Session["WriterMail"] = writer.WriterMail;

                return RedirectToAction("Index", "WriterPanelProfile");
            }
            else
            {
                ViewBag.ErrorMessage = "Hatalı mail veya şifre!";
                return View();
            }
        }

        public ActionResult WriterLogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("WriterLogIn");
        }
    }
}

