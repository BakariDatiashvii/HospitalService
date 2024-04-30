using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;
using HospitalService.Domain.Entities.Users;
using HospitalService.Domain.Service;
using HospitalService.Infrastructure;
using HospitalService.Shared.Enumes;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;

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


            

            byte[] passwordHash;
            byte[] passwordSalt;

            AuthService authService = new AuthService();

           

            if (!authService.ValidatePassword(_model.Password))
            {
                return Result.Success("პაროლი უნდა შეიცავდეს მინიმუმ რვა ასოს, რიცხვს, დიიდ ასოს და სიმბოლოს ");
            }

            authService.CreatePasswordHash(_model.Password, out passwordHash, out passwordSalt);


            var pers = await _repositoryProvider.Persons.GetQueryable().FirstOrDefaultAsync(x => x.ActivateCode == _model.ActivateCode && x.VerifyUser == false);
            if (pers == null)
            {
                return Result.Error("pizdec");
            }

            if ( pers.ActivateCode != _model.ActivateCode)
            {
                return Result.Error("კოდი არასწორია");

            }

            pers.VerifyUser = true;
            pers.ActivateCode = null;
           




            var User = new User()
            {
                Email = _model.Email,
                Role = Role.Person,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FirstName = _model.FirstName,
                LastName = _model.LastName,
                PrivateNumber = _model.PrivateNumber,

                PersonId = pers.Id

            
                


            };

            
            




            var token = _authorizedUserService.GenerateToken(User);
            _repositoryProvider.Persons.Update(pers);
            _repositoryProvider.Users.Create(User);
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success((object)token);


        }
    }
}
