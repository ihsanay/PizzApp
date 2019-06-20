using PizzApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.DataAccess.Concrete.EntityFramework
{
    public class PizzaContext : DbContext
    {
        public PizzaContext()
        {
            Database.SetInitializer<PizzaContext>(null); //null - Şimdilik mssql'den oluşturulacak. DB kod tarafından üretilmeyecek.
        }

        public DbSet<Product> Products { get; set; }
    }
}
