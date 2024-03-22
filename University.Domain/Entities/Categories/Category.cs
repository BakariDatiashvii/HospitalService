using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.Categories
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
