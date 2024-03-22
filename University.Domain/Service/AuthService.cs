using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalService.Domain.Service
{
    public class AuthService
    {

        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
            }
            return true;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }



        public bool ValidatePassword(string password)
        {
            // Check if the password has at least 8 characters and contains numbers, symbols, upper/lowercase letters
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            // Regex pattern to check if the password contains at least one number, one symbol, and one uppercase letter
            var pattern = new Regex(@"^(?=.*[0-9])(?=.*[!@_?#$%^&*-])(?=.*[a-z])(?=.*[A-Z]).{8,}$");

            return pattern.IsMatch(password);
        }

    }
}
