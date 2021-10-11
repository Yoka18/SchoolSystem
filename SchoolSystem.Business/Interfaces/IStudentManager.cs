using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Models;

namespace SchoolSystem.Business.Interfaces
{
    public interface IStudentManager
    {
        List<Student> GettAll();

        void Save(Student student);

        

        void Delete(int Id);
    }
}
