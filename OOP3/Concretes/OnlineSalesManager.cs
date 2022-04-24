using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP3.Abstracts;
using OP3.Entities;

namespace OOP3.Concretes
{
    public class OnlineSalesManager : ISalesService
    {
        public void DoSales(User user)
        {
            CustomerValidationManager cManager = new CustomerValidationManager();

            if (cManager.Validation(user))
            {
                Console.WriteLine(
                $"{user.UserName} bought game on online platform.");
            }
            else
            {
                Console.WriteLine($"Something wrong in customer information. Sales not made ");
            }
        }
    }
}