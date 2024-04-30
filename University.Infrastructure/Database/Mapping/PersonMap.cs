using HospitalService.Domain.Entities.Doctors;
using HospitalService.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Database.Mapping
{
    public static class PersonMap
    {
        public static void ConfigurePerson(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Person>();

            entity.ToTable(nameof(Person), "person");

            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedNever();
            entity.Property(x => x.ActivateCode).HasMaxLength(20);
            entity.Property(x=> x.VerifyUser).IsRequired();
            entity.HasOne(x => x.User).WithOne(x => x.Person).HasForeignKey<Person>(x => x.UserId);
        }
    }
}
