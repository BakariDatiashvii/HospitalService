using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Shared.Models;
using SimpleSoft.Mediator;

namespace HospitalService.Command
{
    public abstract class CommandBase
    {
        protected RepositoryProvider _repositoryProvider { get; }
        protected IAuthorizedUserService _authorizedUserService { get; }

        public CommandBase(RepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }

        protected CommandBase(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService)
        {
            _repositoryProvider = repositoryProvider;
            _authorizedUserService = authorizedUserService;
        }

        public abstract Task<Result> HandleAsync();
    }
}
