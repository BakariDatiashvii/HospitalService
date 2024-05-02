using HospitalService.Domain.Contracts.Repositories.Base;
using HospitalService.Domain.Entities.Calendaries;
using HospitalService.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Contracts.Repositories
{
    public interface ICalendaryRepository : IGenerycRepository<Calendary>
    {
    }
}
