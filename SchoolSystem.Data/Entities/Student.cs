using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{
    public class Student : BaseEntity
    {
        public string tename { get; set; }

        public Teacher teacher { get; set; }

        

    }

}