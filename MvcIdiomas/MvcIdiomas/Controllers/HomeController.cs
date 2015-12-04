
using System.Web.Mail;
using System.Web.Mvc;
using MvcIdiomas.Models;

namespace MvcIdiomas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Persona model)
        {
            if(ModelState.IsValid)
                return RedirectToAction("Index");

            return View(model);
        }

        public ActionResult Correo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Correo(Correo model)
        {
            var msg = new MailMessage();
            msg.Subject = model.Asunto;
            msg.Body = model.Mensaje;
            msg.To.Add(model.Destino);
            
            
        }
    }
}