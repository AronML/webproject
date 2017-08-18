using System.Linq;
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

namespace TutorialAspNetIdentity.Web.Controllers
{
    public class MyHouseController : Controller
    {
       
       


        [Authorize]
        public ActionResult Index()
        {
            string strCurrentUserId = User.Identity.GetUserId();
            
            Arduino arduino = new Arduino();
            //string resposta = arduino.gas();
            string resposta = "aa";

            if (resposta == "Possivel Vazamento de Gas\r")
            {
                ViewData["arduino"] = "Senhor Aron temos um possível vazamento de gás";
                ViewData["warning"] = "Houve um problema com gás, durante um periodo de tempo, verifique!";
                
               
                
                EmailService es = new EmailService();
                IdentityMessage message = new IdentityMessage() { Subject = "Urgência DOHQA", Destination = "aronmpa@gmail.com", Body = "Senhor Aron temos um possível vazamento de gás em sua residência, pedimos que entre em contato com os orgãos competentes."};
                es.SendAsync(message);
            }
            else
            {
                ViewData["arduino"] = "Sem vazamentos de gás";
            }
                
           //string resposta = "tudo certo";
            

            
            UserInfoManager UIm = new UserInfoManager();
            UserInfo userFound = new UserInfo();
            userFound = UIm.FinUserInfoById(strCurrentUserId);

            if (userFound == null)
            {
                return RedirectToAction("UserRegister", "UserInfo");
            }
                    

            PlaceManager pm = new PlaceManager();
            List<Place> dPlaces = pm.FindPlace(strCurrentUserId);
            ViewData["info"] = dPlaces ;

            ObjManager om = new ObjManager();
            List<Obj> dObjs = om.FindObj(strCurrentUserId);
            ViewData["info2"] = dObjs;


            return View();
        }
        [Authorize]
         public ActionResult AddPlace()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AddPlace(AddPlaceViewModel model)
        {
            bool sts = false;
            if (ModelState.IsValid)
            {

                string strCurrentUserId = User.Identity.GetUserId();
                var place = new  Place {Name = model.Name, UserId = strCurrentUserId, Deleted = false};
                PlaceManager pm = new PlaceManager();
                sts = pm.Inserir(place);
            }
            if (sts == true)
            {
                return RedirectToAction("Success", "Results");
            }
            else
            {
                return RedirectToAction("Error", "Results");
            }
            
        }
        [Authorize]
        [HttpGet]
        public ActionResult UpdatePlace()
        {
            return View();
        }
        [Authorize]
        
        public ActionResult UpdatePlace(UpdatePlaceViewModel model, int id)
        {
            bool sts = false;
            if (ModelState.IsValid)
            {
                string strCurrentUserId = User.Identity.GetUserId();
                var place = new Place {  Id = id, Name = model.Name, Deleted = false, UserId = strCurrentUserId};
                PlaceManager pm = new PlaceManager();
                sts = pm.Update(place);
            }
            if (sts == true)
            {
                return RedirectToAction("Success", "Results");
            }
            else
            {
                return RedirectToAction("Error", "Results");
            }
        }
        [Authorize]
        [HttpGet]
        public ActionResult DeletePlace()
        {
            return View();
        }
        [Authorize]
        
        public ActionResult DeletePlace(int id)
        {
            bool sts = false;
            if (ModelState.IsValid)
            {

                string strCurrentUserId = User.Identity.GetUserId();
                PlaceManager pm = new PlaceManager();
                Place lPlaces = pm.FindPlaceById(id);
                var place = new Place { UserId = strCurrentUserId, Deleted = true, Id = id, Name = lPlaces.Name };
                sts = pm.Delete(place);
            }
            if (sts == true)
            {
                return RedirectToAction("Success", "Results");
            }
            else
            {
                return RedirectToAction("Error", "Results");
            }

        }
        
    }
}