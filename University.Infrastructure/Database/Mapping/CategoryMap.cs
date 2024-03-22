using HospitalService.Domain.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Database.Mapping
{
    public static class CategoryMap
    {
        public static void ConfigureCategory(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Category>();

            entity.ToTable(nameof(Category), "category");

            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedNever();

            entity.Property(x => x.Name).HasMaxLength(50).IsRequired();
        }
    }
}
