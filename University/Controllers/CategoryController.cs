using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Query.Queries.CategoryQueriesss;
using HospitalService.Query.Queries.CategoryWIthDoctors;
using Microsoft.AspNetCore.Mvc;

namespace HospitalService.WebApi.Controllers
{
    [ApiController]
    [Route(nameof(CategoryController))]
    public class CategoryController : BaseController
    {
        public CategoryController(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService) : base(repositoryProvider, authorizedUserService)
        {
        }

        [HttpGet("getallcategory")]

        public async Task<IActionResult> GetAllCategory()
        {
            var query = new GetCategoryQueriess(_repositoryProvider);

            var result = await query.HandleAsync();
            return Ok(result.Response);
        }

        [HttpGet("getallcategoryWithDoctor/{id}")]

        public async Task<IActionResult> GetAllCategoryWithDoctor(Guid id )
        {
            var query = new GetCategoryDoctorsQuery(_repositoryProvider, id);
            var result = await query.HandleAsync();
            return Ok(result.Response);
        }
    }
}
