using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pk2_Invitacion.Models;
namespace Pk2_Invitacion.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        // GET: /Home/RsvpForm

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Buenos Dias!!" : hour > 19 ? "Buenas Noches!!" : "Buenas Tardes!!";

            return View();

        }
        //Rendera el link de la forma RSVP
        
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
                {

                    return View("Agradecimientos", guestResponse);
                }
            else
            {

                return View();
            }
        }

    }
    }
    

