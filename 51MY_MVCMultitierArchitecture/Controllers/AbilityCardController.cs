using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _51MY_MVCMultitierArchitecture.Controllers
{
    public class AbilityCardController : Controller
    {
        AbilityCardManager abilityCardManager = new AbilityCardManager(new EfAbilityCardDal());

        // GET: AbilityCard
        public ActionResult Index()
        {
            var values = abilityCardManager.GetList();
            return View(values);
        }
    }
}