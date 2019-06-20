using PizzApp.Core.DataAccess.EntityFramework;
using PizzApp.DataAccess.Abstract;
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

    }
}
