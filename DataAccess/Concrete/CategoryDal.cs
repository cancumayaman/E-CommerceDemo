using DataAccess.Abstract;
using Entities.Concrete;

 namespace DataAccess.Concrete
 {
    public class CategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public CategoryDal(ApplicationDbContext context) : base(context)
        {

        }
    }
 }




