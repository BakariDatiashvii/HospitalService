using HospitalService.Infrastructure;
using HospitalService.Query.ViewModels.DoctorWithCategoryAdminsVm;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Query.Queries.GetDoctorWithCategoryAdmins
{
    public class GetDoctorWithCategoryAdmin : QueryBase
    {
        private readonly Guid _id;

      

        public GetDoctorWithCategoryAdmin(RepositoryProvider repositoryProvider, Guid id) : base(repositoryProvider)
        {
            _id = id;
        }

        public async override Task<Result> HandleAsync()
        {
            var doctorandcategory = await _repositoryProvider.CategoryDoctors.GetQueryable().Include(X=> X.Category). Include(x => x.Doctor).ThenInclude(X=> X.user).
                FirstOrDefaultAsync(x => x.Id == _id && x.IsDeleted !=true);

            if (doctorandcategory == null)
            {
                return Result.Error("ver ipova");
            }
            var VM = new GetDoctorWithCategoryAdminsVm();

            VM.FullName = doctorandcategory.Doctor.user.FirstName;
            VM.Photo = doctorandcategory.Doctor.photo;
            VM.CategoryName = doctorandcategory.Category.Name;


            string C = doctorandcategory.Doctor.user.FirstName;
            
            return Result.Success(VM);
             

        }


        
    }
}
