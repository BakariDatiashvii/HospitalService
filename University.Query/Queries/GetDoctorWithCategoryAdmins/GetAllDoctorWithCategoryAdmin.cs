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
    public class GetAllDoctorWithCategoryAdmin : QueryBase
    {
        public GetAllDoctorWithCategoryAdmin(RepositoryProvider repositoryProvider) : base(repositoryProvider)
        {
        }

        public async override Task<Result> HandleAsync()
        {

            var doctorebi = await _repositoryProvider.CategoryDoctors.GetQueryable().Where(x=> x.IsDeleted != true).Select(x => new GetDoctorWithCategoryAdminsVm()
            {
                FullName = x.Doctor.user.FirstName + x.Doctor.user.LastName,
                CategoryName = x.Category.Name,
                Photo = x.Doctor.photo
               




            }).ToListAsync();


            return Result.Success(doctorebi);
        }
    }
}
