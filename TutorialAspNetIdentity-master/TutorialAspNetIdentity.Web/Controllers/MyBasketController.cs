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
    public class MyBasketController : Controller
    {
        // GET: MyBasket
        [Authorize]
        public ActionResult Index()
        {
             
            string strCurrentUserId = User.Identity.GetUserId();
            MyBasketManager bm = new MyBasketManager();
            List<MyBasket> baskets = bm.FindBasket(strCurrentUserId);
            ViewData["MyBasket"] = baskets;

            ProductManager pm = new ProductManager();

            List<Products> lProducts = pm.FindProducts();
            ViewData["infoProduct"] = lProducts;
            
            return View();
        
        }
        [Authorize]
        [HttpGet]
        public ActionResult Address()
        {
            return View();
        }
        public ActionResult Address(AddressBasketViewModel model)
        {
            bool sts = false;
            if (ModelState.IsValid)
            {
                sts = true;
                
            }
            return RedirectToAction("Payment", "MyBasket");
        }
        [Authorize]
        public ActionResult Payment()
        {
            return View();
        }
        [Authorize]
        public ActionResult AddBasket(int id)
        {
            bool sts = false;
            string strCurrentUserId = User.Identity.GetUserId();
            MyBasket basket = new MyBasket() { product = id, userid = strCurrentUserId, quantidade = 1 };
            MyBasketManager bm = new MyBasketManager();
            sts = bm.Insert(basket);
            return RedirectToAction("Index", "MyBasket");
        }
        [Authorize]
        public ActionResult DeleteBasket(int id)
        {
            bool sts = false;
            MyBasket basket = new MyBasket() { id = id };
            MyBasketManager bm = new MyBasketManager();
            sts = bm.Delete(basket);
            return RedirectToAction("Index", "MyBasket");
        }

        [Authorize]
        [HttpGet]
        public ActionResult quantPlusChange(int id)
        {
            MyBasketManager bm = new MyBasketManager();
            MyBasket lbasket = bm.FindBasketById(id);
            var basket = new MyBasket();

            basket = new MyBasket { id = id, quantidade = lbasket.quantidade + 1 };


            bm.QuantChange(basket.id, basket.quantidade);

            return RedirectToAction("Index", "MyBasket");
        }
        [Authorize]
        public ActionResult quantMinusChange(int id)
        {
            MyBasketManager bm = new MyBasketManager();
            MyBasket lbasket = bm.FindBasketById(id);
            var basket = new MyBasket();

            basket = new MyBasket { id = id, quantidade = lbasket.quantidade - 1 };


            bm.QuantChange(basket.id, basket.quantidade);

            return RedirectToAction("Index", "MyBasket");
        }
    }
}