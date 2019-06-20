using PizzApp.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace PizzApp.DataAccess.Concrete.EntityFramework.Mappings
{
    class ProductTypeMap : EntityTypeConfiguration<ProductType>
    {
        public ProductTypeMap()
        {
            ToTable(@"ProductTypes", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Name).HasColumnName("Name");
        }
    }
}