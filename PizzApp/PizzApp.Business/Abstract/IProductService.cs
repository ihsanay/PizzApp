using PizzApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetById(int id);
        Product Add(Product product);
    }
}
