using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator validator = new ContactValidator();

        // GET: AdminContact
        public ActionResult Index()
        {
            var values = contactManager.GetList();
            return View(values);
        }

        public ActionResult GetContactDetails(int id)
        {
            var values = contactManager.GetById(id);
            return View(values);
        }

        public PartialViewResult SideBarMenu()
        {
            return PartialView();
        }
    }
}
