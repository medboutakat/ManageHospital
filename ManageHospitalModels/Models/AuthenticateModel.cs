using System;
using System.Globalization;

namespace   ManageHospitalModels.Models
{
    public class AuthenticateModel
    { 
        public string Username { get; set; }
         
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