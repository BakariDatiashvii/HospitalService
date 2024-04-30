using HospitalService.Domain.Entities.Categories;
using HospitalService.Domain.Entities.CategoryDoctors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Database.Mapping
{
    public static class CategoryDoctorMap
    {
        public static void ConfigureCategoryDoctor(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<CategoryDoctor>();

            entity.ToTable(nameof(CategoryDoctor), "CategoryDoctor");

            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedNever();

            entity.HasOne(x=> x.Doctor).WithMany(x=> x.Categories).HasForeignKey(x=>x.DoctorId);

            entity.HasOne(x => x.Category)
                .WithMany(x => x.doctors)
                .HasForeignKey(x => x.CategoryId);
                
        }

    }
}
