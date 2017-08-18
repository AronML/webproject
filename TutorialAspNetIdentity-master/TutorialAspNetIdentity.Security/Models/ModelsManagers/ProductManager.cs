using System;
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
    public class ProductManager
    {
        public Boolean Insert(Products product)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Products.Add(product);
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
        public List<Products> FindProducts()
        {
            List<Products> dProducts = new List<Products>();
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    dProducts = conexao.Products.ToList();
                    //var vPlaces = conexao.Place.ToList();
                }
               
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return dProducts;
        }
        public Boolean Delete(Products product)
        {
            try
            {
                using (ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Products.Attach(product);
                    conexao.Products.Remove(product);
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
        public Boolean Update(Products product)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Products.Attach(product);
                    conexao.Entry(product).State = EntityState.Modified;
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
