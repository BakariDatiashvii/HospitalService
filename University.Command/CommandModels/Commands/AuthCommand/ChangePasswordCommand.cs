using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;

using HospitalService.Domain.Entities.Users;
using HospitalService.Domain.Service;
using HospitalService.Infrastructure;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.Commands.AuthCommand
{
    public class ChangePasswordCommand : CommandBase
    {
        protected readonly ChangePasswordCommandModel _model;
        public ChangePasswordCommand(RepositoryProvider repositoryProvider,IAuthorizedUserService authorizedUserService, ChangePasswordCommandModel model) : base(repositoryProvider, authorizedUserService)
        {
            _model = model;
        }

        public async override Task<Result> HandleAsync()
        {
            DateTime x = DateTime.Now.AddMinutes(1);
           
            if (_model.Password !=_model.ConfirmPassword)
            {
                return Result.Error("parolebi arasworia");
            }

          


            var pers = await _repositoryProvider.Persons.GetQueryable().FirstOrDefaultAsync(x => x.ActivateCode != null && x.ActivateCode == _model.ActivateCode && x.VerifyUser == true); 

           if ( x <  DateTime.Now )
            {
                pers.ActivateCode = null;
                _repositoryProvider.Persons.Update(pers);
                _repositoryProvider.UnitOfWork.SaveChange();
                return Result.Error("dro gavida");

            }

            if (pers == null)
            {
                return Result.Error("pizdec");
            }

            if (pers.ActivateCode != _model.ActivateCode)
            {
                return Result.Error("კოდი არასწორია");

            }

           


            byte[] passwordHash;
            byte[] passwordSalt;

            AuthService authService = new AuthService();



            if (!authService.ValidatePassword(_model.Password))
            {
                return Result.Success("პაროლი უნდა შეიცავდეს მინიმუმ რვა ასოს, რიცხვს, დიიდ ასოს და სიმბოლოს ");
            }

            authService.CreatePasswordHash(_model.Password, out passwordHash, out passwordSalt);


            var User1 = await _repositoryProvider.Users.GetQueryable().FirstOrDefaultAsync(x => x.PersonId == pers.Id);

            if (User1 == null)
            {
                return Result.Error("pizdec1");
            }

            pers.ActivateCode = null;

            User1.PasswordHash = passwordHash;
            User1.PasswordSalt = passwordSalt;

            _repositoryProvider.Persons.Update(pers);
            _repositoryProvider.Users.Update(User1);
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success("paroli warmatebit Sheicvala");
        }
    }
}
