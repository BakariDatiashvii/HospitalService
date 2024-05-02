using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Command.CommandModels.Commands.AuthCommand;
using HospitalService.Command.CommandModels.Commands.CalendaryCommands;
using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Query.Queries.CalendaryQueries;
using HospitalService.Query.Queries.CategoryWIthDoctors;
using Microsoft.AspNetCore.Mvc;

namespace HospitalService.WebApi.Controllers
{
    [ApiController]
    [Route(nameof(CategoryController))]
    public class CaledaryController : BaseController
    {
        public CaledaryController(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService) : base(repositoryProvider, authorizedUserService)
        {
        }

        [HttpPost("crate-visit")]

        public async Task<IActionResult> CreateCaledarVisit(CreateVisitCommandModel model)
        {
            var command = new CreateVisitCommand(_repositoryProvider, _authorizedUserService, model);
            return Ok(await command.HandleAsync());

        }


        [HttpDelete("delete-visit/{ID}")]

        public async Task<IActionResult> DeleteCaledarVisit(Guid ID )
        {
            var command = new DeleteVisitCommand(_repositoryProvider, _authorizedUserService, ID);
            return Ok(await command.HandleAsync());

        }


        [HttpGet("get-visit/{ID}")]

        public async Task<IActionResult> GetCaledarVisit(Guid ID)
        {
            var query = new GetCalendaryDoctor(_repositoryProvider, ID);
            var result = await query.HandleAsync();
            return Ok(result.Response);
        }
    }
}
