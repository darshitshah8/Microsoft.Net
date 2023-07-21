using CustomAuthentication.Data;
using CustomAuthentication.InputTypes;
using CustomAuthentication.Models;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CustomAuthentication.Validation
{
    public class AuthLogic : IAuthLogic
    {
        private readonly UserDbContext _usesrContext;

        public AuthLogic(UserDbContext usesrContext)
        {
            _usesrContext = usesrContext;
        }

        #region Validation 
        private string ResigstrationValidations(RegisterInputType registerInput)
        {
            if (string.IsNullOrEmpty(registerInput.EmailAddress))
            {
                return "Eamil can't be empty";
            }

            if (string.IsNullOrEmpty(registerInput.Password)
                || string.IsNullOrEmpty(registerInput.ConfirmPassword))
            {
                return "Password Or ConfirmPasswor Can't be empty";
            }

            if (registerInput.Password != registerInput.ConfirmPassword)
            {
                return "Invalid confirm password";
            }

            string emailRules = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            if (!Regex.IsMatch(registerInput.EmailAddress, emailRules))
            {
                return "Not a valid email";
            }

            // atleast one lower case letter
            // atleast one upper case letter
            // atleast one special character
            // atleast one number
            // atleast 8 character length
            string passwordRules = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            if (!Regex.IsMatch(registerInput.Password, passwordRules))
            {
                return "Not a valid password";
            }

            return string.Empty;
        }
        #endregion

        #region Encryption
        private string PasswordHash(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }
        #endregion

        #region Register New User
        public string Register(RegisterInputType registerInput)
        {

            string errorMessage = ResigstrationValidations(registerInput);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            var newUser = new UserModel
            {
                EmailAddress = registerInput.EmailAddress,
                FirstName = registerInput.FirstName,
                LastName = registerInput.LastName,
                Password = PasswordHash(registerInput.ConfirmPassword)
            };

            _usesrContext.User.Add(newUser);
            _usesrContext.SaveChanges();

            // default role on registration
            var newUserRoles = new UserRolesModel
            {
                Name = "admin",
                UserId = newUser.UserId
            };

            _usesrContext.UserRoles.Add(newUserRoles);
            _usesrContext.SaveChanges();

            return "Registration success";
        } 
        #endregion  
    }
}
