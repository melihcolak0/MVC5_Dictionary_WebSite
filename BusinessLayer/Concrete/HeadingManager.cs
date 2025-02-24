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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void ActivateHeadingBL(Heading heading)
        {
            _headingDal.ActivateHeading(heading);            
        }

        public void AddHeadingBL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void DeleteHeadingBL(Heading heading)
        {            
            _headingDal.Update(heading);
        }

        public Heading GetById(int id)
        {
            return _headingDal.Get(x => x.HeadingId == id);
        }

        public string GetCategoryNameByMostHeadingCount()
        {
            return _headingDal.GetCategoryNameByMostHeadingCount();
        }

        public int GetHeadingCountByCategory(string categoryName)
        {
            return _headingDal.GetHeadingCountByCategory(categoryName);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

        public List<Heading> GetListByWriter(int id)
        {
            return _headingDal.List(x => x.WriterId == id);
        }

        public void UpdateHeadingBL(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
