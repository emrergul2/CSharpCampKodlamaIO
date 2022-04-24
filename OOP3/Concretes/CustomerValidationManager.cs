using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP3.Abstracts;
using OP3.Entities;

namespace OOP3.Concretes
{
    public class CustomerValidationManager : IValidationService
    {
        public bool Validation(User user)
        {
            if (user.FirstName == "Emre" && user.LastName =="Ergul" && 
            user.BirthDate == Convert.ToDateTime("22/09/1995") && 
            user.IdentityNumber=="12345678910")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}