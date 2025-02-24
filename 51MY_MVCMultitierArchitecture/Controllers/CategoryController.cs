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
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCategories()
        {
            //var values = categoryManager.GetAllBL();
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
            ValidationResult results = categoryValidator.Validate(p);

            if(results.IsValid)
            {
                categoryManager.AddCategoryBL(p);
                return RedirectToAction("ListCategories");
            }
            else
            {
                foreach(var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }

            return View();
        }
    }
}

