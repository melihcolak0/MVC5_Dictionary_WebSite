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
    public class AuthorizationController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());

        // GET: Authorization
        public ActionResult Index()
        {
            var values = adminManager.GetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminManager.AddAdminBL(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var value = adminManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAdmin(Admin p)
        {
            adminManager.UpdateAdminBL(p);
            return RedirectToAction("Index");
        }
    }
}

