using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP3.Abstracts;

namespace OP3.Entities
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}