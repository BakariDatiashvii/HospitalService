using HospitalService.Domain.Entities.Doctors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Database.Mapping
{
    public static class DoctorMap
    {
        public static void ConfigureDoctor(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Doctor>();

            entity.ToTable(nameof(Doctor), "doctor");

            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedNever();
            entity.Property(x => x.photo).IsRequired();
            entity.Property(x => x.cv).IsRequired();

            //entity.HasOne(x => x.Category).WithMany(x => x.Doctors).HasForeignKey(x => x.CategoryID);

        }
    }
}
