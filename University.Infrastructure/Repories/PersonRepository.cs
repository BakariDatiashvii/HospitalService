using HospitalService.Domain.Contracts.Repositories;
using HospitalService.Domain.Entities.Doctors;
using HospitalService.Infrastructure.Database;
using HospitalService.Infrastructure.Repories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Repories
{
    public class PersonRepository : GenerycRepository<Person>, IPersonRepository
    {
        public PersonRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
