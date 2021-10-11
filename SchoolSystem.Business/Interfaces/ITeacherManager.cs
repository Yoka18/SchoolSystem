using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Business.Interfaces
{
    public interface ITeacherManager
    {
        List<Teacher> GetAll();

        void Save(Teacher teacher);

        void Delete(int Id);

        
    }
}
