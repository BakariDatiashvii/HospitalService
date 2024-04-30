using HospitalService.Domain.Core;
using HospitalService.Domain.Entities.CategoryDoctors;
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
      //  public Guid doctorID { get; set; }
        public string Name { get; set; }
       public List<CategoryDoctor>  doctors { get; set; }
    }
}


