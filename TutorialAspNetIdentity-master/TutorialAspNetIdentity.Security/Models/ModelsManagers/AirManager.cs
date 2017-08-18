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
    public class AirManager
    {
        
        public Boolean Insert(Air air)
        {
            try
            {
               
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                { 
                    conexao.Air.Add(air);
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
        public List<Air> FindAir(string userId, int placeId)
        {
            List<Air> lair = new List<Air>();
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                { 
                    lair = conexao.Air.Where(o => o.UserId.Equals(userId) && o.PlaceId.Equals(placeId)).ToList();
                    //var vPlaces = conexao.Place.ToList();
                }
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return lair;
        }
        public Boolean TempChange(int id, int temp)
        {
            var air = new Air() { Id = id, Temp = temp};
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                { 
                    conexao.Air.Attach(air);
                    conexao.Entry(air).Property(x => x.Temp).IsModified = true;
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
        public Air FindAirById(int id)
        {
            using (var conexao = new ApplicationDbContext())
            {
                Air air = conexao.Air.Find(id);
                return air;
            }
        }
        public Boolean OnOff(int id, bool onn)
        {
            var air = new Air() { Id = id, Onn = onn};
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Air.Attach(air);
                    conexao.Entry(air).Property(x => x.Onn).IsModified = true;
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
