using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Command.CommandModels.AuthCommandModels
{
    public class RegistrationDoctorCommandModel
    {
        public string Email { get; set; }


        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PrivateNumber { get; set; }

        public IFormFile photo { get; set; }
        public IFormFile cv { get; set; }

        public string categoryname { get; set; }
    }
}
