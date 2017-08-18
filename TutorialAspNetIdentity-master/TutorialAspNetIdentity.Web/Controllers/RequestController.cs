using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TutorialAspNetIdentity.Security.Models.ModelsManagers;
using TutorialAspNetIdentity.Security.Models;

namespace TutorialAspNetIdentity.Web.Controllers
{
    public class RequestController : Controller
    {
        // GET: Request
        public async Task<ActionResult> request(int id)
        {
            try
            {
                ObjManager om = new ObjManager();
                Obj lObj = om.FindObjById(id);

                string metod;
                if (lObj.StatusObj == true)
                {
                    metod = "?acenderluz";
                }
                else
                {
                    metod = "?apagarluz";
                }

                string noip = "http://192.168.100.27/";

                string noipmetod = noip + metod;

                using (var client = new HttpClient())
                {
                    
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

                    using (var a = await client.GetAsync("http://globo.com"))
                   { 
                        String respTxt = await a.Content.ReadAsStringAsync();

                        Console.WriteLine(respTxt);
                        ViewData["resp"] = respTxt;
                        return Redirect("~/Obj/StatusChange/" + id);
                   } 
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }
    }
}