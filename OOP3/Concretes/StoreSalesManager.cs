using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP3.Abstracts;
using OP3.Entities;

namespace OOP3.Concretes
{
    public class StoreSalesManager : ISalesService
    {
        public void DoSales(User user)
        {
            CustomerValidationManager cManager = new CustomerValidationManager();

            if (cManager.Validation(user))
            {
                Console.WriteLine(
                        $"{user.UserName} bought game on store"
                    );
            }
            else {
                Console.WriteLine($"Something wrong in customer information. Sales not made ");
            }

        }
    }
}