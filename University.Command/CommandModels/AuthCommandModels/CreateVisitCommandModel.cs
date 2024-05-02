using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.AuthCommandModels
{
    public class CreateVisitCommandModel
    {
            
        public Guid PersonId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime datetime { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
