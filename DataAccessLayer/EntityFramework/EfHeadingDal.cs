using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
        public void ActivateHeading(Heading heading)
        {
            heading.HeadingStatus = true;
            Update(heading);
        }        

        public string GetCategoryNameByMostHeadingCount()
        {
            using (var context = new Context())
            {
                return context.Headings.GroupBy(x => x.Category.CategoryName)
                                        .OrderByDescending(x => x.Count())
                                        .Select(x => x.Key)
                                        .FirstOrDefault();
            }
        }

        public int GetHeadingCountByCategory(string categoryName)
        {
            using (var context = new Context())
            {
                return context.Headings.Count(t => t.Category.CategoryName == categoryName);                
            }
        }
    }
}
