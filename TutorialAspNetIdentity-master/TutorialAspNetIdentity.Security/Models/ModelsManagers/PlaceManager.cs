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
    public class PlaceManager
    {
        public Boolean Inserir(Place place)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Place.Add(place);
                    conexao.SaveChanges();
                }
               
                                            
            }
            
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
            
            return true;

        }
        public Boolean Update(Place place)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Place.Attach(place);
                    conexao.Entry(place).State = EntityState.Modified;
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
        public Boolean Delete(Place place)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Place.Attach(place);
                    conexao.Entry(place).State = EntityState.Modified;

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
       public List<Place> FindPlace (string place)
        {
            List<Place> dPlaces = new List<Place>();
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    dPlaces = conexao.Place.Where(p => p.UserId.Equals(place)).ToList();
                    //var vPlaces = conexao.Place.ToList();

                }
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
                 
            }

            return dPlaces;
        }
        public Place FindPlaceById (int id)
       {
           
            using(var conexao = new ApplicationDbContext())
            {
                Place place = conexao.Place.Find(id);
                return place;
            }
                
                
       }
                   
            
    }
}
