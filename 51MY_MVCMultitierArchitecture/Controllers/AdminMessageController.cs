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
    public class AdminMessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();

        // GET: AdminMessage
        
        public ActionResult Inbox(string p)
        {
            p = (string)Session["AdminUserName"];            

            var values = messageManager.GetListInbox(p);
            return View(values);
        }

        public ActionResult Sendbox(string p)
        {
            p = (string)Session["AdminUserName"];

            var values = messageManager.GetListSendbox(p);
            return View(values);
        }

        public ActionResult GetSendboxDetails(int id)
        {
            var values = messageManager.GetById(id);
            return View(values);
        }

        public ActionResult GetInboxDetails(int id)
        {
            var values = messageManager.GetById(id);
            return View(values);
        }

        [HttpGet]
        public ActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddMessage(Message p)
        {
            ValidationResult validationResult = messageValidator.Validate(p);

            if (validationResult.IsValid)
            {
                p.MessageDate = DateTime.Now;
                messageManager.AddMessageBL(p);
                return RedirectToAction("Sendbox");
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