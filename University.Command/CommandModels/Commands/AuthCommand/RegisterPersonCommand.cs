using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;
using HospitalService.Domain.Entities.Persons;
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
    public class RegisterPersonCommand : CommandBase
    {
        public readonly RegisterPersonCommandModel _model;
        public RegisterPersonCommand(RepositoryProvider repositoryProvider,
        IAuthorizedUserService authorizedUserService, RegisterPersonCommandModel model)
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

           

            if (!authService.ValidatePassword(_model.Password))
            {
                return Result.Success("პაროლი უნდა შეიცავდეს მინიმუმ რვა ასოს, რიცხვს, დიიდ ასოს და სიმბოლოს ");
            }

            authService.CreatePasswordHash(_model.Password, out passwordHash, out passwordSalt);

            var User = new User()
            {
                Email = _model.Email,
                Role = Role.Person,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FirstName = _model.FirstName,
                LastName = _model.LastName,
                PrivateNumber = _model.PrivateNumber,
                Person = new Person()
                {
                    ActivateCode = _model.ActivateCode
                }


            };

            var token = _authorizedUserService.GenerateToken(User);

            _repositoryProvider.Users.Create(User);
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success((object)token);


        }
    }
}
