using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.DoctorCalendars
{
    public class DoctorCalendar : EntityBase
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Text { get; set; }
        public string? Color { get; set; }

        public Guid DoctorID { get; set; }
        public Doctor doctors { get; set; }
    }
}
