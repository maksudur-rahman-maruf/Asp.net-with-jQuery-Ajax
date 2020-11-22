using mvcCrudDbFirst.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCrudDbFirst.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        db_testEntities dbObj = new db_testEntities();
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            if(ModelState.IsValid)
            {
                tbl_Student obj = new tbl_Student();
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Description = model.Description;

                dbObj.tbl_Student.Add(obj);
                dbObj.SaveChanges();
            }
            ModelState.Clear();

            return View("Student");
        }

        public ActionResult StudentList()
        {
            var res = dbObj.tbl_Student.ToList();
            return View(res);
        }

    }
}