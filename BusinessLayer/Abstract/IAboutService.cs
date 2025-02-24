using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();

        void AddAboutBL(About about);

        About GetById(int id);

        void DeleteAboutBL(About about);

        void UpdateAboutBL(About about);
    }
}
