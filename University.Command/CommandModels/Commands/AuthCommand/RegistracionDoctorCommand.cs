using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;
using HospitalService.Domain.Entities.Categories;
using HospitalService.Domain.Entities.Doctors;
using HospitalService.Domain.Entities.Users;
using HospitalService.Domain.Service;
using HospitalService.Infrastructure;
using HospitalService.Shared.Enumes;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.Commands.AuthCommand
{
    public class RegistracionDoctorCommand : CommandBase
    {
        public readonly RegistrationDoctorCommandModel _model;
        public RegistracionDoctorCommand(RepositoryProvider repositoryProvider,
        IAuthorizedUserService authorizedUserService, RegistrationDoctorCommandModel model)
            : base(repositoryProvider, authorizedUserService)
        {
            _model = model;

        }

        public async override Task<Result> HandleAsync()
        {
            var similarUser = await _repositoryProvider.Users.GetQueryable()
                .FirstOrDefaultAsync(x => x.Email == _model.Email);

            if (similarUser != null)
            {
                return Result.Error("მსგავსი მეილით მომხმარებელი უკვე არსებობს");
            }


            byte[] passwordHash;
            byte[] passwordSalt;

            AuthService authService = new AuthService();
            authService.CreatePasswordHash(_model.Password, out passwordHash, out passwordSalt);

            byte[] POTO = null;
            byte[] CV = null;
            using (var memoryStreamm = new MemoryStream())
            {
                await _model.photo.CopyToAsync(memoryStreamm);


                POTO = memoryStreamm.ToArray();





            }

            using (var memoryStreamm1 = new MemoryStream())
            {
                await _model.photo.CopyToAsync(memoryStreamm1);


                CV = memoryStreamm1.ToArray();





            }

            var User = new User()
            {
                Email = _model.Email,
                Role = Role.Doctor,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FirstName = _model.FirstName,
                LastName = _model.LastName,
                PrivateNumber = _model.PrivateNumber,


                Doctor = new Doctor()
                {
                    photo = POTO,
                    cv = CV,

                    Category = new Category()
                    {
                        Name = _model.categoryname
                    }

                }



            };






            var token = _authorizedUserService.GenerateToken(User);

            _repositoryProvider.Users.Create(User);
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success((object)token);



        }
    }
}
