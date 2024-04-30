using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;

using HospitalService.Infrastructure;
using HospitalService.Shared.EmailServices;
using HospitalService.Shared.EmailServices.EmailContracts;
using HospitalService.Shared.EmailServices.EmailDomaines.EmailModels;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.Commands.AuthCommand
{
    public class ChangePasswordEmailSendValidateCodeCommand : CommandBase
    {

        protected readonly ChangePasswordEmailSendValidateCodeCommandModel _model;

        protected readonly IMailService _mailService;

        public ChangePasswordEmailSendValidateCodeCommand(RepositoryProvider repositoryProvider,
            IAuthorizedUserService authorizedUserService,
            IMailService mailService, ChangePasswordEmailSendValidateCodeCommandModel model) : base(repositoryProvider, authorizedUserService)
        {
            _model = model;
            _mailService = mailService;
        }

        public async override Task<Result> HandleAsync()
        {
            var similarUser = await _repositoryProvider.Users.GetQueryable()
                 .FirstOrDefaultAsync(x => x.Email == _model.Email);



            if (similarUser == null)
            {
                return Result.Error("მსგავსი მეილით მომხმარებელი არ არსებობს");
            }

            var code = RendomStringGenerators.RandomCode(4);

            await _mailService.SendEmailAsync(new MailRequest()
            {
                Body = $"<p>ვერტიფიკაციის კოდი - {code}</p>",
                Mail = _model.Email
            });


            var person = await _repositoryProvider.Persons.GetQueryable() .FirstOrDefaultAsync(x => x.Id ==  similarUser.PersonId);

            if (person == null)
            {
                return Result.Error("pizdec2");
            }

            

            person.VerifyUser = true;
            person.ActivateCode = int.Parse(code);

          


            

            _repositoryProvider.Persons.Update(person);
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success("კოდი წარმატებით გაიგზავნა");
        }
    }
}
