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
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        // GET: AdminCategory
        
        public ActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(p);

            if(result.IsValid)
            {
                categoryManager.AddCategoryBL(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = categoryManager.GetById(id);
            categoryManager.DeleteCategoryBL(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = categoryManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category p)
        {
            categoryManager.UpdateCategoryBL(p);
            return RedirectToAction("Index");
        }
    }
}

