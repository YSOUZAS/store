using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Data.Models;
using Store.DataAccess.Extensions;

namespace Store.DataAccess.Mappings
{
    public class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(s => s.Address)
                   .WithOne(a => a.Supplier);

            builder.HasMany(s => s.Products)
                   .WithOne(p => p.Supplier)
                   .HasForeignKey(p => p.SupplierId);

            builder.CreateStringRequiredWithLengthMapping(p => p.Document, 14);
            builder.CreateNameMapping();

            builder.CreateAtMapping();
            builder.UpdateAtMapping();

            builder.ToTable("Suppliers");
        }
    }
}
