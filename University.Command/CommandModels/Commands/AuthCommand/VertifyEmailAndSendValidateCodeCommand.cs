using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;
using HospitalService.Domain.Entities.Doctors;
using HospitalService.Domain.Entities.Persons;
using HospitalService.Domain.Entities.Users;
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
    public class VertifyEmailAndSendValidateCodeCommand : CommandBase
    {
        
        private readonly VertifyEmailAndSendValidateCodeCommandModel _model;

        protected readonly IMailService _mailService;

        public VertifyEmailAndSendValidateCodeCommand(RepositoryProvider repositoryProvider,
            IAuthorizedUserService authorizedUserService,
            IMailService mailService,
            VertifyEmailAndSendValidateCodeCommandModel model) : base(repositoryProvider, authorizedUserService)
        {
            _model = model;
            _mailService = mailService;
        }

        public async override Task<Result> HandleAsync()
        {
            var similarUser = await _repositoryProvider.Users.GetQueryable()
                .FirstOrDefaultAsync(x => x.Email == _model.Email);



            if (similarUser != null)
            {
                return Result.Error("მსგავსი მეილით მომხმარებელი უკვე არსებობს");
            }

            var code = RendomStringGenerators.RandomCode(4);

            await _mailService.SendEmailAsync(new MailRequest()
            {
                Body = $"<p>ვერტიფიკაციის კოდი - {code}</p>",
                Mail = _model.Email
            });

            var person = new Person()
            {
                ActivateCode = int.Parse(code),
                VerifyUser = false


            };


            _repositoryProvider.Persons.Create(person);
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success("კოდი წარმატებით გაიგზავნა");

            

        }
    }
}
