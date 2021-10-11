using SchoolSystem.Business.Manager;
using SchoolSystem.Models;
using SchoolSystem.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolSystem.Controllers
{
    public class TeacherController : Controller
    {
        TeacherManager teacherManager = new TeacherManager();
        
        SystemConnection db = new SystemConnection();



        //int count = db.Student.Cart.Where(C => C.UserName == "Amit").Count();

        //var ogrenciler = db.Student.ToList(Int32.Parse(student.tename));

        //int[] ints = Array.ConvertAll(student.tename, s => int.Parse(s));

        //var ogrenciSayii = db.Student.ToList().Select(int.Parse(student.tename)).ToList();

        //var ogrenciSayi = db.Student.ToList();

        //var ogrenciler = ogrenciSayi.Count();

        //Convert.ToInt32(student.tename);

        //var ogrenciSayi = db.Student.Find(student.tename);



        // GET: Teacher

        public ActionResult Result(Teacher teacher)           
        {

            Teacher vm = new Teacher()
            {
                stvalue = db.Student.Count()
            };

            return View(vm);
        }

        public ActionResult Index()
        {
            List<Teacher> tec = teacherManager.GetAll();
            return View(tec);

        }
        [HttpGet]
        public ActionResult Save()
        {
            return View("TeacherForm");
        }

        [HttpPost]
        public ActionResult Save(Teacher teacher)
        {
            teacherManager.Save(teacher);
            return RedirectToAction("Index", "Teacher");
        }

        public ActionResult Update(int id)
        {
            var model = db.Teacher.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("TeacherForm", model);
        }

        public ActionResult Delete(int id)
        {
            teacherManager.Delete(id);
            return RedirectToAction("Index");
        }




    }
}