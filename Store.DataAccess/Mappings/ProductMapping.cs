using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Data.Models;
using Store.DataAccess.Extensions;

namespace Store.DataAccess.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.CreateStringRequiredWithLengthhMapping(p => p.Name, 200);
            builder.CreateStringRequiredWithLengthhMapping(p => p.Description, 200);
            builder.CreateStringRequiredWithLengthhMapping(p => p.Image, 200);

            builder.Property(p => p.UpdateAt).ValueGeneratedOnAddOrUpdate().Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save); ;

            builder.CreateAtMapping();
            builder.UpdateAtMapping();

            builder.ToTable("Products");
        }
    }
}
