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
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        [Authorize]
        [HttpGet]
        public ActionResult UserRegister()
        {
            return View();
        }
        [Authorize]
        public ActionResult UserRegister(UserRegisterViewModels model)
        {
            bool sts = false;
            if(ModelState.IsValid)
            {
                string strCurrentUserId = User.Identity.GetUserId();
                UserInfoManager UIm = new UserInfoManager();
                var iUser = new UserInfo { Id = strCurrentUserId, Name = model.Name, Cep = model.Cep, Cidade = model.Cidade, Cpf = model.Cpf, Endereco = model.Endereco, Estado = model.Estado, Nascimento = model.Nascimento , Profissao = model.Profissao};
                sts = UIm.Insert(iUser);
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
        public ActionResult UpdateUserInfo(string id)
        {
            string strCurrentUserId = User.Identity.GetUserId();
            UserInfoManager UIm = new UserInfoManager();
            UserInfo userFound = new UserInfo();
            userFound = UIm.FinUserInfoById(id);
           
            if (userFound == null)
            {
                return RedirectToAction("UserRegister", "UserInfo");
            }
            else
            {
                ViewData["infoUser"] = userFound;

                return View();
            }

            
        }
        [Authorize]
        [HttpPost]
        public ActionResult UpdateUserInfo(UserRegisterViewModels model)
        {

            bool sts = false;
            if (ModelState.IsValid)
            {

                string strCurrentUserId = User.Identity.GetUserId();
                UserInfoManager UIm = new UserInfoManager();
                var iUser = new UserInfo { Id = strCurrentUserId, Name = model.Name, Cep = model.Cep, Cidade = model.Cidade, Cpf = model.Cpf, Endereco = model.Endereco, Estado = model.Estado, Nascimento = model.Nascimento, Profissao = model.Profissao };
                sts = UIm.Update(iUser);
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
        public ActionResult DeleteUserInfo()
        {
            return View();
        }
        [Authorize]
        public ActionResult DeleteUserInfo(UserRegisterViewModels model)
        {
            bool sts = false;
            if (ModelState.IsValid)
            {
                string strCurrentUserId = User.Identity.GetUserId();
                UserInfoManager UIm = new UserInfoManager();
                var iUser = new UserInfo { Id = strCurrentUserId};
                sts = UIm.Insert(iUser);
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