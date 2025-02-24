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
    public class WriterPanelContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());        

        // GET: WriterPanelContent
        
        public ActionResult MyContents(string p)
        {
            p = (string)Session["WriterMail"];                                  
            var writerIdInfo = writerManager.GetWriterId(p);

            var values = contentManager.GetListByWriter(writerIdInfo);
            return View(values);
        }

        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.IdInfo = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];                                 
            var writerIdInfo = writerManager.GetWriterId(mail);

            p.ContentDate = DateTime.Now;
            p.WriterId = writerIdInfo;
            p.ContentStatus = true;
            contentManager.AddContentBL(p);
            return RedirectToAction("MyContents");
        }
    }
}