using PizzApp.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace PizzApp.DataAccess.Concrete.EntityFramework.Mappings
{
    class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.ProductTypeId).HasColumnName("ProductTypeId");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Price).HasColumnName("Price");
            Property(x => x.Desc).HasColumnName("Desc");
            Property(x => x.DiscountPrice).HasColumnName("DiscountPrice");
        }
    }
}