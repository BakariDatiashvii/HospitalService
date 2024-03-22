using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.Persons
{
    public class Person : EntityBase
    {
        public string ActivateCode { get; set; }

        public User User { get; set; }
    }
}
