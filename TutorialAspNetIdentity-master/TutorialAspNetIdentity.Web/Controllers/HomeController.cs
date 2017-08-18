using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using TutorialAspNetIdentity.Security.Identity;
using TutorialAspNetIdentity.Security.Models;
using TutorialAspNetIdentity.Web.Models.Identity;
using TutorialAspNetIdentity.Web.Models;
using TutorialAspNetIdentity.Security.Models.ModelsManagers;
using TutorialAspNetIdentity.Web.Controllers;
using System.Collections.Generic;
using System;

namespace TutorialAspNetIdentity.Web.Controllers
{
    
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
          

            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactViewModels model)
        {
           
            EmailService es = new EmailService();
            IdentityMessage message = new IdentityMessage() { Subject = "Mensagem Contato DOHQA", Destination = "dohqad@gmail.com", Body = "De " + model.Email + " , " + model.Cidade + " , " + model.Estado + " Mensagem: - " + model.Mensagem};
            es.SendAsync(message);

            return RedirectToAction("Success", "Results");
        }
        
        public ActionResult Video()
        {
            ViewBag.Message = "Your videos.";

            return View();
        }
        [Authorize]
        public ActionResult SignOut()
        {
            ViewBag.Message = "Sair";

            return View();
        }
    }
}
