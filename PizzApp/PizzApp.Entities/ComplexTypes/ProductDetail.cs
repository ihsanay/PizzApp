using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.Entities.ComplexTypes
{
    public class ProductDetail
    {
        //virtual - NHibernate için
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Desc { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal DiscountPrice { get; set; }
        public virtual int TypeId { get; set; }
        public virtual string Type { get; set; }

    }
}
