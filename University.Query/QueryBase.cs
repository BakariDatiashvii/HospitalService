using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Shared.Models;
using SimpleSoft.Mediator;

namespace HospitalService.Query
{
    public abstract class QueryBase
    {
        protected RepositoryProvider _repositoryProvider { get; }
        protected IAuthorizedUserService _authorizedUserService { get; }

        public QueryBase(RepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }

        protected QueryBase(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService)
        {
            _repositoryProvider = repositoryProvider;
            _authorizedUserService = authorizedUserService;
        }

        public abstract Task<Result> HandleAsync();
    }
}
