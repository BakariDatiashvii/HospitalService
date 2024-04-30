using HospitalService.Domain.Entities.Categories;
using HospitalService.Infrastructure;
using HospitalService.Query.ViewModels.CategoryDoctorWm;
using HospitalService.Query.ViewModels.CategoryVm;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Query.Queries.CategoryWIthDoctors
{
    public class GetCategoryDoctorsQuery : QueryBase
    {
        private readonly Guid _id;

        public GetCategoryDoctorsQuery(RepositoryProvider repositoryProvider, Guid id) : base(repositoryProvider)
        {
            _id = id;
        }

        public async override Task<Result> HandleAsync()
        {
            var category = await _repositoryProvider.Categorys.GetQueryable().FirstOrDefaultAsync(x=> x.Id == _id);

            var categoryDoctor = _repositoryProvider.CategoryDoctors.GetQueryable()
                .Where(x=> x.CategoryId == category.Id).Select( z => new GetCategoryDoctorsVm()
            {
                    FullName = z.Doctor.user.FirstName + "" + z.Doctor.user.LastName,
                    Photo = z.Doctor.photo,

                    CategoryName = _repositoryProvider.CategoryDoctors.GetQueryable()
                    .Where(x => x.DoctorId == z.Doctor.Id ).Select(t => new GetCategoryVm()
                    {
                        Name = t.Category.Name
                    }).ToList(),



                }).ToList();

            if (category == null)
            {
                return Result.Error("ar aris");
            }



              return Result.Success(categoryDoctor);

            
            
        }
    }
}
