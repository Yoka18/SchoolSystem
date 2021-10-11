using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{

    public class Teacher : BaseEntity
    {
        public int stvalue { get; set; }

        public bool IsActive { get; set; }

    }
}