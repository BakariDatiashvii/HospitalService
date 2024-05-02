using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Calendaries;
using HospitalService.Domain.Entities.Categories;
using HospitalService.Domain.Entities.CategoryDoctors;
using HospitalService.Domain.Entities.DoctorCalendars;
using HospitalService.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.Doctors
{
    public class Doctor : EntityBase
    {
        public byte[] photo { get; set; }
        public byte[] cv { get; set; }
        public User user { get; set; }
       // public Guid CategoryID { get; set; }

        public List<CategoryDoctor> Categories { get; set; }

        public List<Calendary> calendaries { get; set; }
        
        //public List<DoctorCalendar> DoctorCalendar { get; set; }

      
    }
}
