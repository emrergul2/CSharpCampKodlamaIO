using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OP3.Entities;

namespace OOP3.Abstracts
{
    public interface IValidationService
    {
        bool Validation(User user);
    }
}