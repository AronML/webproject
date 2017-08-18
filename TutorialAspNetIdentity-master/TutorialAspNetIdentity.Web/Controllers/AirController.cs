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
    public class AirController : Controller
    {
        // GET: Air
        
        [Authorize]
        [HttpGet]
        public ActionResult Index(int id)
        {
            string strCurrentUserId = User.Identity.GetUserId();
            AirManager am = new AirManager();
            List<Air> lair = am.FindAir(strCurrentUserId, id);
            ViewData["info3"] = lair;
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult TempPlusChange(int id)
        {
            AirManager am = new AirManager();
            Air lair = am.FindAirById(id);
            var air = new Air();

            air = new Air { Id = id, Temp = lair.Temp + 1 };


            am.TempChange(air.Id, air.Temp);

            return Redirect("http://localhost:29644/Air/Index/" + lair.PlaceId);
        }
        [Authorize]
        [HttpGet]
        public ActionResult TempMinusChange(int id)
        {
            AirManager am = new AirManager();
            Air lair = am.FindAirById(id);
            var air = new Air();

            air = new Air { Id = id, Temp = lair.Temp - 1 };


            am.TempChange(air.Id, air.Temp);

            return Redirect("http://localhost:29644/Air/Index/" + lair.PlaceId);
        }
        [Authorize]
        [HttpGet]
        public ActionResult OnOff(int id)
        {
            AirManager am = new AirManager();
            Air lair = am.FindAirById(id);
            var air = new Air();
            if(lair.Onn == true)
            {
                air = new Air { Id = id, Onn = false };
            }
            else
            {
                 air = new Air { Id = id, Onn = true };
            }
           
            am.OnOff(air.Id, air.Onn);

            return Redirect("http://localhost:29644/Air/Index/" + lair.PlaceId);
        }
        [Authorize]
        [HttpGet]
        public ActionResult AddAir()
        {
            return View();
        }
        
        [Authorize]
        public ActionResult AddAir(AddAirViewModel model, int id)
        {
            bool sts = false;
            AirManager am = new AirManager();
            string strCurrentUserId = User.Identity.GetUserId();
            Air air = new Air { Name = model.Name, Onn = false, Temp = 15, UserId = strCurrentUserId, PlaceId = id };
            sts = am.Insert(air);
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