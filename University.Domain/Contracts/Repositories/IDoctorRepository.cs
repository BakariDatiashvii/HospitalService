﻿using HospitalService.Domain.Contracts.Repositories.Base;
using HospitalService.Domain.Entities.Categories;
using HospitalService.Domain.Entities.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Contracts.Repositories
{
    public interface IDoctorRepository : IGenerycRepository<Doctor>
    {
    }
}
