using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BCrypt.Net;  
  
namespace AngularRegistration.Utilities  
{  
    public static class Utility  
    {  
        public static string Encryptpassword(string password)  
        {  
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(12));  
            return hashedPassword;  
        }  
  
        public static bool CheckPassword(string enteredPassword, string hashedPassword)  
        {  
            bool pwdHash = BCrypt.Net.BCrypt.CheckPassword(enteredPassword, hashedPassword);  
            return pwdHash;  
        }  
    }  
}  