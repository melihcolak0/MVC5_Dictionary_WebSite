using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
        public Admin GetAdmin(string username)
        {
            using (var context = new Context())  // Veritabanı Context
            {
                return context.Admins.FirstOrDefault(x => x.AdminUserName == username);
            }
        }

        public Admin GetUser(Admin p)
        {
            using (var context = new Context())  // Veritabanı Context
            {
                return context.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName &&
                x.AdminPasswrod == p.AdminPasswrod);
            }
        }
    }
}
