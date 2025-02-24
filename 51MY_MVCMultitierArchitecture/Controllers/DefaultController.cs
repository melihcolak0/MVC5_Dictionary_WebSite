using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());

        // GET: Default
        public PartialViewResult Index(int id = 0)
        {
            var values = contentManager.GetListByHeadingId(id);
            return PartialView(values);
        }

        public ActionResult Headings()
        {
            var values = headingManager.GetList();
            return View(values);
        }
    }
}