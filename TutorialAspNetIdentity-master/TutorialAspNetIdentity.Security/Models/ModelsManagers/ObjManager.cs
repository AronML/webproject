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
    public class ObjManager
    {
        public Boolean Insert(Obj obj)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                { 
                    conexao.Obj.Add(obj);
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
        public Boolean Update(Obj obj)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Obj.Attach(obj);
                    conexao.Entry(obj).Property(x => x.NameActivated).IsModified = true;
                    conexao.Entry(obj).Property(x => x.NameDesativated).IsModified = true;

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
        public Boolean Delete(Obj obj)
        {
            
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Obj.Attach(obj);
                    conexao.Entry(obj).Property(x => x.deleted).IsModified = true;

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
        public List<Obj> FindObj(string obj)
        {
            List<Obj> dobjs = new List<Obj>();
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    dobjs = conexao.Obj.Where(o => o.userId.Equals(obj)).ToList();
                    //var vPlaces = conexao.Place.ToList();
                }
                
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return dobjs;
        }
        public Obj FindObjById(int id)
        {
            using (var conexao = new ApplicationDbContext())
            {
                Obj obj = conexao.Obj.Find(id);
                return obj;
            }
        }
        public Boolean StatusChange(int id, bool status)
        {
            var obj = new Obj() { Id = id, StatusObj = status };
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.Obj.Attach(obj);
                    conexao.Entry(obj).Property(x => x.StatusObj).IsModified = true;
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
    }
}
