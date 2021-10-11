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
    public class StudentManager : IStudentManager
    {
        public void Delete(int Id)
        {
            using (SystemConnection db = new SystemConnection())
            {
                var deletedstudent = db.Student.Find(Id);
                db.Student.Remove(deletedstudent);
                db.SaveChanges();
            }
        }

        public List<Student> GettAll()
        {
            using (SystemConnection db = new SystemConnection())
            {
                return db.Student.ToList();
            }
        }

        public void Save(Student student)
        {
            using (SystemConnection db = new SystemConnection())
            {
                if (student.Id == 0) // if Id 0 added, else updated
                {
                    db.Student.Add(student);
                }
                else
                {
                    var updatedstudent = db.Teacher.Find(student.Id);
                    if (updatedstudent == null)
                    {
                        return;
                    }
                    updatedstudent.name = student.name;
                    updatedstudent.surname = student.surname;
                    updatedstudent.age = student.age;
                    updatedstudent.sex = student.sex;

                }
                db.SaveChanges();
            }


        }
    }
}
