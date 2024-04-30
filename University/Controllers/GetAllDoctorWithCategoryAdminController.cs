using HospitalService.Command.CommandModels.Commands.DoctorWithCategoryAdminCommands;
using HospitalService.Command.CommandModels.UpdateDoctorWithCategoryAdminCommandModel;
using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Query.Queries.CategoryQueriesss;
using HospitalService.Query.Queries.GetDoctorWithCategoryAdmins;
using HospitalService.Shared.Enumes;
using HospitalService.WebApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace HospitalService.WebApi.Controllers
{
    public class GetAllDoctorWithCategoryAdminController : BaseController
    {
        public GetAllDoctorWithCategoryAdminController(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService) : base(repositoryProvider, authorizedUserService)
        {
        }
       // [Authorize(Role.Admin)]
        [HttpGet("AllDoctorWithCategoryAdmin")]

        public async Task<IActionResult> AllDoctorWithCategoryAdmin()
        {
            var query = new GetAllDoctorWithCategoryAdmin(_repositoryProvider);

            var result = await query.HandleAsync();
            return Ok(result.Response);
        }


        [Authorize(Role.Admin)]
        [HttpGet("DoctorWithCategoryAdmin/{id}")]

        public async Task<IActionResult> DoctorWithCategoryAdmins(Guid id)
        {
            var query = new GetDoctorWithCategoryAdmin(_repositoryProvider, id);

            var result = await query.HandleAsync();
            return Ok(result.Response);
        }

        [Authorize(Role.Admin)]
        [HttpDelete("deletee")]

        public async Task<IActionResult> DeleteDoctorAndCategory(Guid id)
        {
            var command = new DeleteDoctorWithCategoryAdminCommand(_repositoryProvider, id);
            var result = await command.HandleAsync();
            return Ok(result.Response);
        }

        [HttpPut("UpdateCategoryDoctor")]
        public async Task<IActionResult> UpdateCategoryDoctor(UpdateDoctorWithCategoryAdminCommandModeli model)
        {
            var command = new UpdateDoctorWithCategoryAdminCommand(_repositoryProvider,_authorizedUserService, model);
            var result = await command.HandleAsync();
            return Ok(result.Response);
        }
    }

}
