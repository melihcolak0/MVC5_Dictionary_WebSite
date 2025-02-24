using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();

        void AddCategoryBL(Category category);

        Category GetById(int id);

        void DeleteCategoryBL(Category category);

        void UpdateCategoryBL(Category category);

        // İstatistikler
        int GetCategoryCount();

        int GetCountStateTrue();

        int GetCountStateFalse();
    }
}
