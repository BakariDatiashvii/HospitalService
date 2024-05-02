using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Doctors;
using HospitalService.Domain.Entities.Persons;
using HospitalService.Shared.Enumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.Users
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public Role Role { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PrivateNumber { get; set; }

        public Guid?  PersonId { get; set; }
        public Person  Person { get; set; }

        public Guid? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
