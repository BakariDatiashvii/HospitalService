using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;
using HospitalService.Domain.Entities.Calendaries;
using HospitalService.Domain.Entities.Users;
using HospitalService.Infrastructure;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalService.Command.CommandModels.Commands.CalendaryCommands
{
    public class CreateVisitCommand : CommandBase
    {
        public readonly CreateVisitCommandModel _model;
        public CreateVisitCommand(RepositoryProvider repositoryProvider, IAuthorizedUserService authorizedUserService, CreateVisitCommandModel model) : base(repositoryProvider, authorizedUserService)
        {
            _model = model;
        }

        public async override Task<Result> HandleAsync()
        {
            var Person  = await _repositoryProvider.Users.GetQueryable()
                .FirstOrDefaultAsync(x => x.PersonId == _model.PersonId );
            if (Person == null)
            {
                return Result.Error("pizdec");
            }


            var Doctor = await _repositoryProvider.Users.GetQueryable()
                .FirstOrDefaultAsync(x => x.DoctorId == _model.DoctorId);

            if (Doctor == null)
            {
                return Result.Error("pizdec");
            }



            var caledary = new Calendary
            {
                DoctorId = _model.DoctorId,
                PersonId = _model.PersonId,
                CreatedDate = DateTime.UtcNow,
                Description = _model.Description,

            };

            _repositoryProvider.Calendarys.Create(caledary);
            _repositoryProvider.UnitOfWork.SaveChange();


            return Result.Success(_model);



        }
    }
}
