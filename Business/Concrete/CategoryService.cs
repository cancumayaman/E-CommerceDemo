using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
