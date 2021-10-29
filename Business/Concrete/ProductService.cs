using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CrossCuttingConcerns.ExceptionHandling;
using Business.CrossCuttingConcerns.Logging;
using Business.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

 namespace Business.Concrete
 {
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        [ExceptionHandling]
        
        public void Add(Product product)
        {
            _productDal.Add(product);
        }


        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productDal.Get(filter);
        }

        [LogAspect]
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
 }
