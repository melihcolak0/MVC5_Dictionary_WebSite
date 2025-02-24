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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        //Context context = new Context();

        public int GetCategoryCount()
        {
            using (var context = new Context()) // using DataAccessLayer.Concrete;
            {
                return context.Categories.Count();                
            }
        }

        public int GetCountStateFalse()
        {
            using (var context = new Context()) // using DataAccessLayer.Concrete;
            {
                return context.Categories.Count(x => x.CategoryStatus == false);
            }
        }

        public int GetCountStateTrue()
        {
            using (var context = new Context()) // using DataAccessLayer.Concrete;
            {
                return context.Categories.Count(x => x.CategoryStatus == true);
            }
        }
    }
}
