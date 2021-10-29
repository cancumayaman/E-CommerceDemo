using DataAccess.Abstract;
using Entities.Concrete;

 namespace DataAccess.Concrete
 {
    public class ProductDal: GenericRepository<Product>, IProductDal
    {
        public ProductDal(ApplicationDbContext context) : base(context)
        {

        }
    }
 }





