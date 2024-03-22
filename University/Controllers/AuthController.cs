using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Command.CommandModels.Commands.AuthCommand;
using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Shared.Enumes;
using HospitalService.WebApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace HospitalService.WebApi.Controllers
{
    [ApiController]
    [Route(nameof(AuthController))]
    public class AuthController : BaseController
    {
        public AuthController(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService) : base(repositoryProvider, authorizedUserService)
        {
        }

        [HttpPost("Person-registration")]
        public async Task<IActionResult> PersonRegistration(RegisterPersonCommandModel model)
        {
            var command = new RegisterPersonCommand(_repositoryProvider, _authorizedUserService, model);

            return Ok(await command.HandleAsync());
        }


        [Authorize(Role.Admin)]

        [HttpPost("Doctor-registration")]
        public async Task<IActionResult> DoctorRegistration([FromForm] RegistrationDoctorCommandModel model)
        {
            var command = new RegistracionDoctorCommand(_repositoryProvider, _authorizedUserService, model);

            return Ok(await command.HandleAsync());
        }


        [HttpPost("login")]
        public async Task<IActionResult> login([FromForm] LoginUserCommandModel model)
        {
            var command = new LoginUserCommand(_repositoryProvider, _authorizedUserService, model);

            return Ok(await command.HandleAsync());
        }

    }
}
