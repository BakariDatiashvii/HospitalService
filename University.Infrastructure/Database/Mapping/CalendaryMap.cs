using HospitalService.Domain.Entities.Calendaries;
using HospitalService.Domain.Entities.CategoryDoctors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Database.Mapping
{
    public static class CalendaryMap
    {
        public static void ConfigureCalendary(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Calendary>();
            entity.ToTable(nameof(Calendary), "Calendary");


            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedNever();


            entity.HasOne(x => x.Doctors).WithMany(x => x.calendaries).HasForeignKey(x => x.DoctorId);

            entity.HasOne(x => x.Persons).WithMany(x => x.calendaries).HasForeignKey(x => x.PersonId);
        }
    }
}
