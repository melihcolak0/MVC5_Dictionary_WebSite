using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminStatisticsController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        // GET: AdminStatistics

        public ActionResult Index()
        {
            ViewBag.CategoryCount = categoryManager.GetCategoryCount();
            ViewBag.GetHeadingCount = headingManager.GetHeadingCountByCategory("Yazılım");
            ViewBag.GetWriterName = writerManager.GetWriterByALetterInName("em");
            ViewBag.GetCategoryName = headingManager.GetCategoryNameByMostHeadingCount();
            ViewBag.GetCategoryCountStateTrue = categoryManager.GetCountStateTrue();
            ViewBag.GetCategoryCountStateFalse = categoryManager.GetCountStateFalse();
            ViewBag.GetCategoryCountStateDif = Math.Abs(categoryManager.GetCountStateTrue() - categoryManager.GetCountStateFalse());
            return View();
        }
    }
}
