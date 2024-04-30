using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.AuthCommandModels
{
    public class ChangePasswordCommandModel
    {
        public int ActivateCode { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
