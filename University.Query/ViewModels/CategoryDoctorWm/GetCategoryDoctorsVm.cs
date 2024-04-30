using HospitalService.Query.ViewModels.CategoryVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Query.ViewModels.CategoryDoctorWm
{
    public class GetCategoryDoctorsVm
    {
        public byte[] Photo { get; set; }
        public string FullName { get; set; }
         
        public List<GetCategoryVm> CategoryName { get; set; }

    }

    
}
