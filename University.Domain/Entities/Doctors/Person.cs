using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.Doctors
{
    public class Person : EntityBase
    {
        public int? ActivateCode { get; set; }

        public bool VerifyUser { get; set; }

        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}
