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
    public class UserInfoManager
    {
        public Boolean Insert(UserInfo IUser)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.UserInfo.Add(IUser);
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

        public Boolean Update(UserInfo iUser)
        {
            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.UserInfo.Attach(iUser);
                    conexao.Entry(iUser).State = EntityState.Modified;
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
        public Boolean Delete(UserInfo iUser)
        {

            try
            {
                using(ApplicationDbContext conexao = new ApplicationDbContext())
                {
                    conexao.UserInfo.Remove(iUser);
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
        
        public UserInfo FinUserInfoById(string id)
        {
            using (var conexao = new ApplicationDbContext())
            {
                UserInfo UInfo = conexao.UserInfo.Find(id);
                return UInfo;
            }
        }
    }
}
