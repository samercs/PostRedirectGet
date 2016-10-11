using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostRedirectGet.Core.Filters;
using PostRedirectGet.Models;

namespace PostRedirectGet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Normal()
        {
            AddUserVm model = new AddUserVm();
            return View(model);
        }

        [HttpPost]
        public ActionResult Normal(AddUserVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ImportModelState]
        public ActionResult Strict()
        {
            AddUserVm model = new AddUserVm();
            return View(model);
        }

        [HttpPost]
        [ExportModelState]
        public ActionResult Strict(AddUserVm model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Strict");
            }
            return RedirectToAction("Index");
        }
    }
}