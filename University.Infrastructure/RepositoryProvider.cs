﻿using HospitalService.Domain.Contracts.Repositories;
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



        public RepositoryProvider(IUnitOfWork unitOfWork,
            IPersonRepository person,
            IDoctorRepository doctor,
            ICategoryRepository category,
            IUserRepository user)
        {
            UnitOfWork = unitOfWork;
            Doctors = doctor;
            Categorys = category;
            Persons = person;
            Users = user;
        }
    }
}
