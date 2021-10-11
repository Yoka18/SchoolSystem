using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models.Context
{
    public class SystemConnection : DbContext
    {

        
        public SystemConnection()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-RPMD112;database=SchoolSystem;Trusted_Connection=true";
        }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Student> Student { get; set; }

       

    }
}