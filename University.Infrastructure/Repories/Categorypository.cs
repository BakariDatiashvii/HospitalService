using HospitalService.Domain.Contracts.Repositories;
using HospitalService.Domain.Entities.Categories;
using HospitalService.Infrastructure.Database;
using HospitalService.Infrastructure.Repories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Infrastructure.Repories
{
    public class Categorypository : GenerycRepository<Category>, ICategoryRepository
    {
        public Categorypository(HospitalDbContext context) : base(context)
        {
        }
    }
}
