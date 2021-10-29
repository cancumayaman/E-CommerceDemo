using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
        Category Get(Expression<Func<Category, bool>> filter);
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
