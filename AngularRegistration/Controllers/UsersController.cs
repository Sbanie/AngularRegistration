using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularRegistration.Models;
using AngularRegistration.Utilities;

namespace AngularRegistration.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        //To check that user entered is already present or not.  
        public bool CheckUser(string user)
        {
            bool Exists = false;
            using (SbanieDbContext context = new SbanieDbContext())
            {
                var uEmail = context.Registers.Where(x => x.Email == user).ToList();
                if (uEmail.Count != 0)
                {
                    Exists = true;
                }
            }
            return Exists;
        }

        //For saving the user details in database table.          
        public string AddUser(Register rgr)
        {
            if (rgr != null)
            {
                if (CheckUser(rgr.Email) == false)
                {
                    using (SbanieDbContext context = new SbanieDbContext())
                    {
                        Register createUser = new Register();
                        createUser.Name = rgr.Name;
                      
                        createUser.Email = rgr.Email;
                        createUser.DateTimeCreated = DateTime.Now;
                        createUser.Password = Utility.Encryptpassword(rgr.Password);
                        
                        context.Registers.Add(createUser);
                        context.SaveChanges();
                    }
                    return "User created !";
                }
                else
                {
                    return "User already present !";
                }
            }
            else
            {
                return "Invalid Data !";
            }
        }
    }
}