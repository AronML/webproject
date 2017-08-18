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
using TutorialAspNetIdentity.Web.Models;
using TutorialAspNetIdentity.Web.Models.Identity;
using TutorialAspNetIdentity.Security.Models.ModelsManagers;
using System.Collections.Generic;
using TutorialAspNetIdentity.Web.Controllers;


namespace TutorialAspNetIdentity.Web.Controllers
{
    public class ObjController : Controller
    {
        // GET: Obj
        [Authorize]
        [HttpGet]
        public ActionResult StatusChange(int id)
        {
            
            ObjManager om = new ObjManager();
            Obj lObj = om.FindObjById(id);
            var obj = new Obj();


            RequestController r = new RequestController();
            r.request(id);
             bool b;
            //string answer = ViewData["resp"].ToString();
            

            
            //if (answer == "A luz foi acesa\r\n") b = true;
           
            //else b = false;


            if (lObj.StatusObj == true )
            {
                obj = new Obj { Id = id, StatusObj = false };
                om.StatusChange(obj.Id, obj.StatusObj);
                
            }
            else
            {
                obj = new Obj { Id = id, StatusObj = true };
                om.StatusChange(obj.Id, obj.StatusObj);
               
            }
                  
            return RedirectToAction("Index", "MyHouse");

        }
        [Authorize]
        [HttpGet]
        public ActionResult InsertObj()
        {
            return View();
        }
        [Authorize]
        
        public ActionResult InsertObj(InsertObjViewModel model, int id)
        {
            bool sts = false;
            if (ModelState.IsValid)
            {
                string strCurrentUserId = User.Identity.GetUserId();
                var obj = new Obj { NameActivated = model.NameActived, NameDesativated = model.NameDesatived, Place = id , userId = strCurrentUserId, deleted = false };
                ObjManager om = new ObjManager();
                sts = om.Insert(obj);
                
                
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
        public ActionResult UpdateObj()
        {
            return View();
        }
        [Authorize]
        public ActionResult UpdateObj(UpdateObjViewModel model, int id)
        {
            bool sts = false;
            if(ModelState.IsValid)
            {
                var obj = new Obj { Id = id, NameActivated = model.NameActived, NameDesativated = model.NameDesatived };
                ObjManager om = new ObjManager();
                sts = om.Update(obj);
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
        public ActionResult DeleteObj()
        {
            return View();
        }
        [Authorize]
        public ActionResult DeleteObj(int id)
        {
            bool sts = false;
            if(ModelState.IsValid)
            {
                
                var obj = new Obj { Id = id, deleted = true };
                ObjManager om = new ObjManager();
                sts = om.Delete(obj);
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