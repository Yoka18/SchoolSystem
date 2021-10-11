using SchoolSystem.Business.Interfaces;
using SchoolSystem.Models;
using SchoolSystem.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Business.Manager
{
    public class TeacherManager : ITeacherManager
    {
        public void Delete(int Id)
        {
            using (SystemConnection db = new SystemConnection())
            {
                var deletedteacher = db.Teacher.Find(Id);
                db.Teacher.Remove(deletedteacher);
                db.SaveChanges();
            }
        }

        public List<Teacher> GetAll()
        {
            using (SystemConnection db = new SystemConnection())
            {
                return db.Teacher.ToList();
            }
        }

        public void Save(Teacher teacher)
        {
            using (SystemConnection db = new SystemConnection())
            {
                if (teacher.Id == 0) // if Id 0 added, else updated
                {
                    db.Teacher.Add(teacher);
                }
                else
                {
                    var updatedteacher = db.Teacher.Find(teacher.Id);
                    if (updatedteacher == null)
                    {
                        return;
                    }
                    updatedteacher.name = teacher.name;
                    updatedteacher.surname = teacher.surname;
                    updatedteacher.age = teacher.age;
                    updatedteacher.sex = teacher.sex;

                }
                db.SaveChanges();
            }
        }

        
    }
}
