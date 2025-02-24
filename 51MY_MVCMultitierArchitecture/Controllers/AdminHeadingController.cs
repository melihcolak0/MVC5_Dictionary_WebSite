using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminHeadingController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        HeadingValidator headingValidator = new HeadingValidator(); 

        // GET: AdminHeading
        public ActionResult Index()
        {
            var values = headingManager.GetList();
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

            List<SelectListItem> writers = (from x in writerManager.GetList()
                                            select new SelectListItem
                                            {
                                                Text = x.WriterName + " " + x.WriterSurName,
                                                Value = x.WriterId.ToString()
                                            }).ToList();
            ViewBag.Categories = categories;
            ViewBag.Writers = writers;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {            
            ValidationResult result = headingValidator.Validate(p);

            if (result.IsValid)
            {
                p.HeadingDate = DateTime.Now;
                headingManager.AddHeadingBL(p);
                return RedirectToAction("Index");
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
                return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }

        public ActionResult ActivateHeading(int id)
        {
            var value = headingManager.GetById(id);
            headingManager.ActivateHeadingBL(value);
            return RedirectToAction("Index");
        }

        public ActionResult HeadingReport()
        {
            var values = headingManager.GetList();
            return View(values);
        }
    }
}