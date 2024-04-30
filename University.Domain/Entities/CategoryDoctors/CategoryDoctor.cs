using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.Categories;
using HospitalService.Domain.Entities.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Domain.Entities.CategoryDoctors
{
    public class CategoryDoctor : EntityBase
    {
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid DoctorId { get; set; }

        public Doctor Doctor { get; set; }
    }
}
