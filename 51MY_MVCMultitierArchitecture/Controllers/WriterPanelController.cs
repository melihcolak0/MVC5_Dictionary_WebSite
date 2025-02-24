using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class WriterPanelController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        HeadingValidator headingValidator = new HeadingValidator();

        // GET: WriterPanel        

        public ActionResult MyHeadings(string p)
        {
            p = (string)Session["WriterMail"];                      
            var writerIdInfo = writerManager.GetWriterId(p);            

            var values = headingManager.GetListByWriter(writerIdInfo);
            return View(values);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> categories = (from x in categoryManager.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();            
            ViewBag.Categories = categories;            
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            string writerMailInfo = (string)Session["WriterMail"];                     
            var writerIdInfo = writerManager.GetWriterId(writerMailInfo);
            p.HeadingDate = DateTime.Now;
            p.WriterId = writerIdInfo;                                    
            p.HeadingStatus = true; 
            headingManager.AddHeadingBL(p);
            return RedirectToAction("MyHeadings");
        }

        [HttpGet]
        public ActionResult UpdateHeading(int id)
        {
            List<SelectListItem> categories = (from x in categoryManager.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();

            ViewBag.Categories = categories;
            var value = headingManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateHeading(Heading p)
        {
            ValidationResult result = headingValidator.Validate(p);

            if (result.IsValid)
            {                
                headingManager.UpdateHeadingBL(p);
                return RedirectToAction("MyHeadings");
            }
            else
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }
        }

        public ActionResult DeleteHeading(int id)
        {
            var value = headingManager.GetById(id);
            value.HeadingStatus = false;
            headingManager.DeleteHeadingBL(value);
            return RedirectToAction("MyHeadings");
        }

        public ActionResult ActivateHeading(int id)
        {
            var value = headingManager.GetById(id);
            headingManager.ActivateHeadingBL(value);
            return RedirectToAction("MyHeadings");
        }

        public ActionResult AllHeadings(int a = 1)
        {
            var values = headingManager.GetList().ToPagedList(a, 4);
            return View(values);
        }
    }
}

