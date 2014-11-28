using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeQuiz.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/
           public ActionResult NotFoundError()
        {
            return HttpNotFound("Trabajador No Encontrad@...");

        }
           public ActionResult NotFound()
           {
               ViewBag.ErrorCode = "NFE0001";
               ViewBag.Description = "El trabajador@ no se encuentra" + "En nuestra BD";
               return View();
           }

        public ActionResult Index()
        {
            return View();
        }

    }
}
