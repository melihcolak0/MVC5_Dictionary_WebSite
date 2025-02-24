using _51MY_MVCMultitierArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminChartController : Controller
    {
        // GET: AdminChart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(CategoryChartList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryChart> CategoryChartList()
        {
            List<CategoryChart> categoryChart = new List<CategoryChart>();
            categoryChart.Add(new CategoryChart()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            categoryChart.Add(new CategoryChart()
            {
                CategoryName = "Seyahat",
                CategoryCount = 4
            });
            categoryChart.Add(new CategoryChart()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 6
            });
            categoryChart.Add(new CategoryChart()
            {
                CategoryName = "Spor",
                CategoryCount = 2
            });

            return categoryChart;
        }
    }
}
