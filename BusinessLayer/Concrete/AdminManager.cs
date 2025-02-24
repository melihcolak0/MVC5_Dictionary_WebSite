using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AddAdminBL(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void DeleteAdminBL(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Admin GetAdmin(string username)
        {
            return _adminDal.GetAdmin(username);
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.List();
        }

        public Admin GetUser(Admin p)
        {
            return _adminDal.GetUser(p);
        }

        public void UpdateAdminBL(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
