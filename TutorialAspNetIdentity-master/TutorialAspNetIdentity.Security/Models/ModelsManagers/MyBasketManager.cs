using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialAspNetIdentity.Security.ContextIdentity;
using TutorialAspNetIdentity.Security.Models;
namespace TutorialAspNetIdentity.Security.Models.ModelsManagers
{
    public class MyBasketManager
    {
        public Boolean Insert(MyBasket basket)
        {
            try
            {
                using (ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.MyBasket.Add(basket);
                    conexao.SaveChanges();
                }

            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }

            return true;

        }

        
        public Boolean Delete(MyBasket basket)
        {

            try
            {
                using (ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.MyBasket.Attach(basket);                    
                    conexao.MyBasket.Remove(basket);
                    conexao.SaveChanges();
                }


            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }

            return true;

        }

        public List<MyBasket> FindBasket(string user)
        {
            List<MyBasket> dbaskets = new List<MyBasket>();
            try
            {
                using (ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    dbaskets = conexao.MyBasket.Where(o => o.userid.Equals(user)).ToList();
                    
                }

            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return dbaskets;
        }
        public MyBasket FindBasketById(int id)
        {
            MyBasket basket = new MyBasket();
            try
            {
                using (ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    basket = conexao.MyBasket.Find(id);

                }

            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return basket;
        }
        public Boolean QuantChange(int id, int quantidade)
        {
            var basket = new MyBasket() { id = id, quantidade = quantidade };
            try
            {
                using (ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.MyBasket.Attach(basket);
                    conexao.Entry(basket).Property(x => x.quantidade).IsModified = true;
                    conexao.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
            return true;

        }
    }
}
