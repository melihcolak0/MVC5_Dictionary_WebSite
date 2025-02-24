using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());

        // GET: AdminContent

        [HttpGet]
        public ActionResult Index()
        {
            var values = contentManager.GetList();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(string p)
        {
            var values = contentManager.GetListBySearch(p);
            return View(values);
        }

        public ActionResult ContentByHeading(int id)
        {
            var values = contentManager.GetListByHeadingId(id);
            return View(values);
        }
    }
}