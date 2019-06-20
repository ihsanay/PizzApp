using PizzApp.Core.DataAccess;
using PizzApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.DataAccess.Abstract
{
    interface IProductDal:IEntityRepository<Product>
    {
    }
}
