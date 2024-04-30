using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Command.CommandModels.Commands.AuthCommand;
using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Shared.EmailServices.EmailContracts;
using HospitalService.Shared.Enumes;
using HospitalService.WebApi.Service;
using MailKit;
using Microsoft.AspNetCore.Mvc;

namespace HospitalService.WebApi.Controllers
{
    [ApiController]
    [Route(nameof(AuthController))]
    public class AuthController : BaseController
    {
        private readonly Shared.EmailServices.EmailContracts.IMailService _mailService;
        public AuthController(
            RepositoryProvider repositoryProvider,
            IAuthorizedUserService authorizedUserService,
            Shared.EmailServices.EmailContracts.IMailService mailService) : base(repositoryProvider, authorizedUserService)
        {
            _mailService = mailService;
        }


        [HttpPost("seendCode")]
        public async Task<IActionResult> VertifyEmailAndSendValidateCode(VertifyEmailAndSendValidateCodeCommandModel model)
        {
            var command = new VertifyEmailAndSendValidateCodeCommand(_repositoryProvider, _authorizedUserService, _mailService ,model );

            return Ok(await command.HandleAsync());
        }


        [HttpPost("CHangePasswordSendCode")]
        public async Task<IActionResult> CHangePasswordSendCode(ChangePasswordEmailSendValidateCodeCommandModel model)
        {
            var command = new ChangePasswordEmailSendValidateCodeCommand(_repositoryProvider, _authorizedUserService, _mailService, model);

            return Ok(await command.HandleAsync());
        }

        [HttpPost("Person-registration")]
        public async Task<IActionResult> PersonRegistration(RegisterPersonCommandModel model)
        {
            var command = new RegisterPersonCommand(_repositoryProvider, _authorizedUserService, model);

            return Ok(await command.HandleAsync());
        }


      

        [HttpPost("Doctor-registration")]
        public async Task<IActionResult> DoctorRegistration([FromForm] RegistrationDoctorCommandModel model)
        {
            var command = new RegistracionDoctorCommand(_repositoryProvider, _authorizedUserService, model);

            return Ok(await command.HandleAsync());
        }


        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody] LoginUserCommandModel model)
        {
            var command = new LoginUserCommand(_repositoryProvider, _authorizedUserService, model);

            return Ok(await command.HandleAsync());
        }

        [HttpPost("UpdateMaailPassword")]
        public async Task<IActionResult> UpdateMaailPassword([FromForm] ChangePasswordCommandModel model)
        {
            var command = new ChangePasswordCommand(_repositoryProvider, _authorizedUserService, model);

            return Ok(await command.HandleAsync());
        }

    }
}
