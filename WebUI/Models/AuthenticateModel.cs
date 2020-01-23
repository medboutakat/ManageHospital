using System;
using System.Globalization;

namespace WebApi.Models
{
    public class AuthenticateModel
    { 
        public string Username { get; set; }
         
        public string Password { get; set; }
    }
    public class UserModel
    {
        //[Required]
        public string FirstName { get; set; }

        //[Required]
        public string LastName { get; set; }

        //[Required]
        public string Username { get; set; }

        //[Required]
        public string Password { get; set; }
    }

    public class AppException : Exception
    {
        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}