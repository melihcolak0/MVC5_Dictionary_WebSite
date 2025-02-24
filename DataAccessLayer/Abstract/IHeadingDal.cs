using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IHeadingDal : IRepository<Heading>
    {
        void ActivateHeading(Heading heading);

        // İstatistikle
        int GetHeadingCountByCategory(string categoryName);

        string GetCategoryNameByMostHeadingCount();
    }
}
