using MeHasVisto1.Models;
using MeHasVisto1.Models.Bussines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto1.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
            string model = null; //PetManagement.GetByName(name);
            if (model == null)
                return RedirectToAction("NotFound");

            return View(model);
        }

        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = "/Content/Uploads/" + name + ".jpg"; //ruta
            var contentType = "image/jpg"; //tipo de identificador
            var fileName = name + ".jpg";
            return File(picture, contentType, fileName);
        }
        public ActionResult NotFound()
        {
            ViewBag.ErrorCode = "NFE0001";
            ViewBag.Description = "La mascota no se encuentra" +
                "En la base de datos";
            return View();
        }

        public HttpStatusCodeResult UnauthorizedError()
        {
            return new HttpUnauthorizedResult("Nada por aqui");
            
        }
        // Action method  que permitira la carga
        // la foto de una mascota
        public ActionResult PictureUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PictureUpload(PictureModel model)
        {
            if (model.PictureFile.ContentLength > 0)
            {
                var fileName = Path.GetFileName(model.PictureFile.FileName);
                var filePath = Server.MapPath("/Content/Uploads");
                string savedFileName = Path.Combine(filePath, fileName);
                model.PictureFile.SaveAs(savedFileName);
                PetManagement.CreateThumbnail(fileName, filePath, 100, 100, true);
            }
            return View(model);
        }
    }
}
