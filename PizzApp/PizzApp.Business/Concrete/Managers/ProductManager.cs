using PizzApp.Business.Abstract;
using PizzApp.Core.DataAccess;
using PizzApp.DataAccess.Abstract;
using PizzApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IQueryableRepository<Product> _queryable;
        public ProductManager(IProductDal productDal, IQueryableRepository<Product> queryable)
        {
            _productDal = productDal;
            _queryable = queryable;
        }
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }
    }
}
