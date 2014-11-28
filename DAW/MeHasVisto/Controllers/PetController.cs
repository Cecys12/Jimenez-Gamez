using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Index()
        {
            return View();
        }

       //public ActionResult Display()
       // {
       //     var name = (string)RouteData.Values["id"];
       //     var model = PetManagement.GetByName(name);
       //     if (model == null)
       //         return RedirecToAcion("NotFound");
       //     return View(model);
       // }

        public string ShowId()
        {
            var id = (string)RouteData.Values["id"];
            return id;
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}
