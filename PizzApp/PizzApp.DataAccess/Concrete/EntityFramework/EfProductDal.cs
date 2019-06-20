using PizzApp.Core.DataAccess.EntityFramework;
using PizzApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.DataAccess.Concrete.EntityFramework
{
    class EfProductDal : EfEntityRepositoryBase<EfProductDal, PizzaContext>, IProductDal
    {

    }
}
