using HospitalService.Domain.Contracts;
using HospitalService.Infrastructure;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.Commands.CalendaryCommands
{
    public class DeleteVisitCommand : CommandBase
    {
        public Guid  _ID { get; set; }
        public DeleteVisitCommand(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService,  Guid iD) : base(repositoryProvider, authorizedUserService)
        {
            _ID = iD;
        }

        public async override Task<Result> HandleAsync()
        {
            var delete = await _repositoryProvider.Calendarys.GetQueryable().FirstOrDefaultAsync(x => x.Id ==_ID);

            delete.Delete();

            _repositoryProvider.Calendarys.Update(delete);
            _repositoryProvider.UnitOfWork.SaveChange();
            return Result.Success("წარმატებით წაიშალა");
        }
    }
}
