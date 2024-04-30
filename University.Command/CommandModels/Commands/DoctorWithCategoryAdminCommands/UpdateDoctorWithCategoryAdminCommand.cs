using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Command.CommandModels.UpdateDoctorWithCategoryAdminCommandModel;
using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.Commands.DoctorWithCategoryAdminCommands
{
    public class UpdateDoctorWithCategoryAdminCommand : CommandBase
    {
        public readonly UpdateDoctorWithCategoryAdminCommandModeli _model;
        public UpdateDoctorWithCategoryAdminCommand(RepositoryProvider repositoryProvider,
        IAuthorizedUserService authorizedUserService, UpdateDoctorWithCategoryAdminCommandModeli model)
            : base(repositoryProvider, authorizedUserService)
        {
            _model = model;

        }


        public async override Task<Result> HandleAsync()
        {
            var updateTask = await _repositoryProvider.CategoryDoctors.GetQueryable().Include(x=> x.Category).Include(x=>x.Doctor).ThenInclude(x=> x.user)
                .FirstOrDefaultAsync(x=> x.Id == _model.Id);
            if (updateTask == null)
            {
                return Result.Error("გამოცდა ვერ მოიძებნა");
            }


            byte[] POTO = null;
           
            using (var memoryStreamm = new MemoryStream())
            {
                await _model.Photo.CopyToAsync(memoryStreamm);


                POTO = memoryStreamm.ToArray();





            }


            updateTask.Doctor.user.FirstName = _model.FirstName;
            updateTask.Doctor.user.LastName = _model.LastName;
            updateTask.Doctor.photo = POTO;

         

            _repositoryProvider.Users.Update(updateTask.Doctor.user);
            _repositoryProvider.Doctors.Update(updateTask.Doctor);
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success("warmatebit ganaxlda");

           

            


        }
    }
}
