using PizzApp.Core.DataAccess.EntityFramework;
using PizzApp.DataAccess.Abstract;
using PizzApp.Entities.ComplexTypes;
using PizzApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, PizzaContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (PizzaContext context = new PizzaContext())
            {
                return (from p in context.Products
                        join t in context.ProductTypes on p.ProductTypeId equals t.Id
                        select new ProductDetail
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Type = t.Name,
                            Price = p.Price,
                            Desc = p.Desc,
                            DiscountPrice = p.DiscountPrice,
                            TypeId = t.Id
                        }).ToList();
            }
        }
    }
}
