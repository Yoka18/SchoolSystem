using SchoolSystem.Business.Manager;
using SchoolSystem.Models;
using SchoolSystem.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolSystem.Controllers
{
    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager();

        SystemConnection db = new SystemConnection();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> stu = studentManager.GettAll();
            return View(stu);
        }

        [HttpGet]
        public ActionResult Save()
        {
            return View("StudentForm");
        }

        [HttpPost]
        public ActionResult Save(Student student, Teacher teacher)
        {
            studentManager.Save(student);
            return RedirectToAction("Index", "Student");
        }

        public ActionResult Update(int id)
        {
            var model = db.Student.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("StudentForm", model);
        }

        public ActionResult Delete(int id)
        {
            studentManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}