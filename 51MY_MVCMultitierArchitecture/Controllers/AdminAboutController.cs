using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminAboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        // GET: AdminAbout
        public ActionResult Index()
        {
            var values = aboutManager.GetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            aboutManager.AddAboutBL(p);
            return RedirectToAction("Index");
        }

        public PartialViewResult AddAboutPartial()
        {
            return PartialView();
        }
    }
}