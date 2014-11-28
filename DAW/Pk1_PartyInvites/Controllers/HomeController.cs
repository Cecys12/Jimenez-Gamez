using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pk1_PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        // GET: /Home/GetTime

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Buenos dias!!!" : "Buenas Tardes!!!";
            return View();
        }
        public ActionResult GetTimeImage()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.hora = hour;
            return View();
        }

    }
}
