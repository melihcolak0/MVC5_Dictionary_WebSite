using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();

        void AddAdminBL(Admin admin);

        Admin GetById(int id);

        void DeleteAdminBL(Admin admin);

        void UpdateAdminBL(Admin admin);

        Admin GetUser(Admin p);

        Admin GetAdmin(string username);
    }
}
