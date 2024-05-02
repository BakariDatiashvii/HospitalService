using HospitalService.Infrastructure;
using HospitalService.Query.ViewModels.CategoryVm;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalService.Query.Queries.CategoryQueriesss
{
    public class GetCategoryQueriess : QueryBase
    {
        public GetCategoryQueriess(RepositoryProvider repositoryProvider) : base(repositoryProvider)
        {
        }

    
        public async override Task<Result> HandleAsync()
        {
            var category = await _repositoryProvider.Categorys.GetQueryable().Where(x => x.IsDeleted == false).Select(x => new GetCategoryVm()
            {
                Id = x.Id,
                Name = x.Name,

            }).ToListAsync();

            return Result.Success(category);
        }
    }
}
