using Ninject.Modules;
using PizzApp.Business.Abstract;
using PizzApp.Business.Concrete.Managers;
using PizzApp.Core.DataAccess;
using PizzApp.Core.DataAccess.EntityFramework;
using PizzApp.DataAccess.Abstract;
using PizzApp.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();

            Bind<IProductDal>().To<EfProductDal>();
            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<PizzaContext>();
        }
    }
}
