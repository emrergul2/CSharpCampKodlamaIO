using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP3.Abstracts;

namespace OOP3.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

    }
}