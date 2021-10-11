using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public int age { get; set; }

        public string sex { get; set; }
    }
}