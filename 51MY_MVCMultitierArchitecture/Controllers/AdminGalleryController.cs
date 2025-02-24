using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminGalleryController : Controller
    {
        ImageFileManager imageFileManager = new ImageFileManager(new EfImageFileDal());

        // GET: AdminGallery
        public ActionResult Index()
        {
            var values = imageFileManager.GetList();
            return View(values);
        }
    }
}