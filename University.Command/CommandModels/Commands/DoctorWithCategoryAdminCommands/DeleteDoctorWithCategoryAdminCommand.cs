using HospitalService.Infrastructure;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.Commands.DoctorWithCategoryAdminCommands
{
    public class DeleteDoctorWithCategoryAdminCommand : CommandBase
    {

        public Guid _id { get; set; }
        public DeleteDoctorWithCategoryAdminCommand(RepositoryProvider repositoryProvider, Guid id) : base(repositoryProvider)
        {
            _id = id;
        }

        public override async Task<Result> HandleAsync()
        {
            var delete = await _repositoryProvider.CategoryDoctors.GetQueryable().FirstOrDefaultAsync(x=> x.Id == _id);

            delete.Delete();

            _repositoryProvider.CategoryDoctors.Update(delete);
            _repositoryProvider.UnitOfWork.SaveChange();
            return Result.Success("წარმატებით წაიშალა");
        }
    }
}
