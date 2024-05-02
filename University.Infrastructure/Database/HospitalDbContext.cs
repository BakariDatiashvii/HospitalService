using HospitalService.Domain.Entities.Calendaries;
using HospitalService.Domain.Entities.Categories;
using HospitalService.Domain.Entities.CategoryDoctors;
using HospitalService.Domain.Entities.Doctors;
using HospitalService.Domain.Entities.Persons;
using HospitalService.Domain.Entities.Users;
using HospitalService.Infrastructure.Database.Initsializers;
using HospitalService.Infrastructure.Database.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Database
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categorys { get; set; }

        public DbSet<CategoryDoctor> CategoryDoctors { get; set; }

        public DbSet<Calendary> calendars { get; set; }



        public HospitalDbContext(DbContextOptions<HospitalDbContext> context) : base(context)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ConfigureCategory();
            modelBuilder.ConfigureDoctor();
            modelBuilder.ConfigurePerson();
            modelBuilder.ConfigureUser();
            modelBuilder.ConfigureCategoryDoctor();
            modelBuilder.ConfigureCalendary();

            modelBuilder.InitializeUser();


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }


    }
}
