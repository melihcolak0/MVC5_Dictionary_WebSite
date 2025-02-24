using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategoryBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void DeleteCategoryBL(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public int GetCategoryCount()
        {
            return _categoryDal.GetCategoryCount();
        }

        public int GetCountStateFalse()
        {
            return _categoryDal.GetCountStateFalse();
        }

        public int GetCountStateTrue()
        {
            return _categoryDal.GetCountStateTrue();
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void UpdateCategoryBL(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
