using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Data.Models;
using Store.DataAccess.Extensions;
namespace Store.DataAccess.Mappings
{
    class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(p => p.Id);

            builder.CreateStringRequiredWithLengthMapping(p => p.Patio, 200);
            builder.CreateStringRequiredWithLengthMapping(p => p.Number, 50);
            builder.CreateStringRequiredWithLengthMapping(p => p.ZipCode, 8);
            builder.CreateStringRequiredWithLengthMapping(p => p.Additional, 250);
            builder.CreateStringRequiredWithLengthMapping(p => p.Neighborhood, 100);
            builder.CreateStringRequiredWithLengthMapping(p => p.State, 100);
            builder.CreateStringRequiredWithLengthMapping(p => p.City, 100);

            builder.CreateAtMapping();
            builder.UpdateAtMapping();

            builder.ToTable("Addresses");
        }
    }
}
