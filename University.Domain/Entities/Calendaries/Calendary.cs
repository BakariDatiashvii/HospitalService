using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Doctors;
using HospitalService.Domain.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.Calendaries
{
    public class Calendary: EntityBase
    {
        public Guid ? PersonId { get; set; }
        public Person Persons { get; set; }


        public Guid ? DoctorId { get; set; }
        public Doctor Doctors { get; set; }

        public DateTime Created { get; set; }

        public string  Description { get; set; }
    }
}
