using HospitalService.Domain.Contracts.Repositories;
using HospitalService.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure
{
    public class RepositoryProvider
    {
        public IUnitOfWork UnitOfWork { get; }
        public IDoctorRepository Doctors { get; }
        public ICategoryRepository Categorys { get; }
        public IPersonRepository Persons { get; }
        public IUserRepository Users { get; }

        public ICategoryDoctorRepository CategoryDoctors { get; }

        public ICalendaryRepository Calendarys { get; }



        public RepositoryProvider(IUnitOfWork unitOfWork,
            IPersonRepository person,
            IDoctorRepository doctor,
            ICategoryRepository category,
            IUserRepository user,
            ICategoryDoctorRepository categoryDoctorRepository,
            ICalendaryRepository calendarys)
        {
            UnitOfWork = unitOfWork;
            Doctors = doctor;
            Categorys = category;
            Persons = person;
            Users = user;
            CategoryDoctors = categoryDoctorRepository;
            Calendarys = calendarys;
        }
    }
}
