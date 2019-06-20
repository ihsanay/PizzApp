using PizzApp.Core.DataAccess;
using PizzApp.Entities.ComplexTypes;
using PizzApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Complex
        List<ProductDetail> GetProductDetails();
    }
}
