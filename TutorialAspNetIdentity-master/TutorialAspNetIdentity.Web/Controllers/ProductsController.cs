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
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ProductManager pm = new ProductManager();
            
            List<Products>lProducts = pm.FindProducts();
            ViewData["infoProduct"] = lProducts;
                           
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Insert()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Insert(InsertProductsViewModels model)
        {
            bool sts = false;
            if(ModelState.IsValid)
            { 
                ProductManager pm = new ProductManager();
                Products product = new Products() { name = model.name, info = model.info, value = model.value };
                sts = pm.Insert(product);
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
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Update(UpdateProductsViewModels model, int id)
        {
            bool sts = false;
            if (ModelState.IsValid)
            {
                Products product = new Products() { id = id, name = model.name, info = model.info, value = model.value};
                ProductManager pm = new ProductManager();
                sts = pm.Update(product);
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

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Delete(DeleteProductsViewModels model, int id)
        {
            bool sts = false;
            if(ModelState.IsValid)
            {
                Products product = new Products() { id = id };
                ProductManager pm = new ProductManager();
                sts = pm.Delete(product);
            }
           

            if (sts == true)
            {
                return RedirectToAction("Deleted", "Results");
            }
            else
            {
                return RedirectToAction("Error", "Results");
            }

        }
        
        
       
    }
}