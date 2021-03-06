using Microsoft.EntityFrameworkCore;
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

            builder.CreateStringRequiredWithLengthMapping(p => p.Description, 200);
            builder.CreateStringRequiredWithLengthMapping(p => p.Image, 200);
            builder.CreateNameMapping();

            builder.CreateAtMapping();
            builder.UpdateAtMapping();

            builder.ToTable("Products");
        }
    }
}
