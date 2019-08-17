using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public PLAN_JOBDISPATCHBLL _PlanJobdispatchbll { get;set; }
     

        public ActionResult Index()
        {
            var model = _PlanJobdispatchbll.LoadEntities(t => t.ACTIVITY == 1).Take(1).FirstOrDefault();
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
    }
}