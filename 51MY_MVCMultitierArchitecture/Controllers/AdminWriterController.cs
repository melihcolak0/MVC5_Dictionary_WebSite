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

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AdminWriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        WriterValidator writerValidator = new WriterValidator();

        // GET: AdminWriter
        public ActionResult Index()
        {
            var values = writerManager.GetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {            
            ValidationResult validationResult = writerValidator.Validate(p);
            if(validationResult.IsValid)
            {
                writerManager.AddWriter(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach(var x in validationResult.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult UpdateWriter(int id)
        {
            var values = writerManager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateWriter(Writer p)
        {
            ValidationResult validationResult = writerValidator.Validate(p);
            if (validationResult.IsValid)
            {
                writerManager.UpdateWriter(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var x in validationResult.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
    }
}
