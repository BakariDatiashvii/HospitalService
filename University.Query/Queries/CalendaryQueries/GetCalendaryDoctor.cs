using HospitalService.Infrastructure;
using HospitalService.Query.ViewModels.CategoryDoctorWm;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Query.Queries.CalendaryQueries
{
    public class GetCalendaryDoctor : QueryBase
    {
        private readonly Guid _id;
        public GetCalendaryDoctor(RepositoryProvider repositoryProvider, Guid id) : base(repositoryProvider)
        {
            _id = id;
        }

        public async override Task<Result> HandleAsync()
        {
            var doctor = await _repositoryProvider.Doctors.GetQueryable().Include(x=> x.calendaries)
               
                .FirstOrDefaultAsync(x => x.Id == _id);
            if (doctor == null)
            {
                return Result.Error("ვერ იპოვა");

            }

           
            var caledar =  doctor.calendaries.Select(x => new CaledaryVm
            {
                dateTime = x.CreatedDate,
                description = x.Description,

            }).ToList();


            return Result.Success(caledar);
            
        }
    }
}
