using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Data.Models;
using System;
using System.Linq.Expressions;

namespace Store.DataAccess.Extensions
{
    public static class MappingExtensions
    {
        public static void CreateAtMapping<T>(this EntityTypeBuilder<T> builder) where T : Entity
        {
            builder.Property(p => p.CreateAt).ValueGeneratedOnAdd();
        }

        public static void UpdateAtMapping<T>(this EntityTypeBuilder<T> builder) where T : Entity
        {
            builder.Property(p => p.CreateAt).ValueGeneratedOnAdd();
        }

        public static void CreateStringRequiredWithLengthMapping<T>(this EntityTypeBuilder<T> builder, Expression<Func<T, string>> predicate, int length) where T : Entity
        {
            builder.Property(predicate)
                   .IsRequired()
                   .HasColumnType($"varchar({length})");
        }

        public static void CreateNameMapping<T>(this EntityTypeBuilder<T> builder) where T : NamedEntity
        {
            builder.CreateStringRequiredWithLengthMapping(p => p.Name, 200);
        }
    }
}
