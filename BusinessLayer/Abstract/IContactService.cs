using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();

        void AddContactBL(Contact contact);

        Contact GetById(int id);

        void DeleteContactBL(Contact contact);

        void UpdateContactBL(Contact contact);
    }
}
