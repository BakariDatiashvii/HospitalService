using HospitalService.Query.ViewModels.CategoryVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Query.ViewModels.DoctorWithCategoryAdminsVm
{
    public class GetDoctorWithCategoryAdminsVm
    {
        public string FullName { get; set; }
        
        public string CategoryName { get; set; }    
   
       
        public byte[] Photo { get; set; }

        

    }
}
