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
    public class WriterPanelProfileController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        
        // GET: WriterPanelProfile

        [HttpGet]
        public ActionResult Index()
        {
            string p = (string)Session["WriterMail"];
            var writerIdInfo = writerManager.GetWriterId(p);
                       
            var value = writerManager.GetById(writerIdInfo);
            return View(value);
        }

        [HttpPost]
        public ActionResult Index(Writer p)
        {
            WriterValidator writerValidator = new WriterValidator();
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

