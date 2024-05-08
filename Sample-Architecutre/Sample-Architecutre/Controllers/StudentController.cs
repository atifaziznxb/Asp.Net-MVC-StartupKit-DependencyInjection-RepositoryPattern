using Sample_Architecutre.Core.Models;
using Sample_Architecutre.Models;
using Sample_Architecutre.Service.StudentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_Architecutre.Controllers
{
    public class StudentController : Controller
    {
        #region Properties

        private IStudentService _studentService;

        #endregion

        #region Constructor

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        #endregion

        #region Actions

        // GET: Student
        public ActionResult Create()
        {
            Student model = new Student() {  Address = "Lahore", Name = "Test", PhoneNumber = "1234567890"};
            _studentService.Insert(model);
            return View();
        }

        #endregion
    }
}