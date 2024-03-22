using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;
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
    public class LoginUserCommand : CommandBase
    {
        private readonly LoginUserCommandModel _model;
        public LoginUserCommand(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService, LoginUserCommandModel model) : base(repositoryProvider, authorizedUserService)
        {
            _model = model;
        }

        public async override Task<Result> HandleAsync()
        {
            var user = await _repositoryProvider.Users.GetQueryable()
               .FirstOrDefaultAsync(x => x.Email == _model.Email);

            if (user == null)
            {
                return Result.Error("მომხმარებელი მსგავსი მეილით ვერ მოიძებნა");
            }

            AuthService authService = new AuthService();

            var isVertified = authService.VerifyPasswordHash(_model.Password, user.PasswordHash, user.PasswordSalt);

            if (!isVertified)
            {
                return Result.Error("პაროლი არასწორია");
            }

            var token = _authorizedUserService.GenerateToken(user);

            return Result.Success((object)token);
        }
    }
}
