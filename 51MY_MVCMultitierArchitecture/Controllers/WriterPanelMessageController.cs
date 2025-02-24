using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();

        // GET: WriterPanelMessage
        public ActionResult Inbox()
        {
            string mail = (string)Session["WriterMail"];
            var values = messageManager.GetListInbox(mail);
            return View(values);
        }

        public ActionResult Sendbox()
        {
            string mail = (string)Session["WriterMail"];
            var values = messageManager.GetListSendbox(mail);
            return View(values);
        }

        public PartialViewResult SideBarMenu()
        {
            return PartialView();
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
            string mail = (string)Session["WriterMail"];

            if (validationResult.IsValid)
            {
                p.MessageDate = DateTime.Now;
                p.SenderMail = mail;
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

