using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCTest.Models.Student;

namespace PCTest.Controllers.Student
{
    public class StudentController : Controller
    {
        
        public IActionResult ResultView()
        {
            List<StudentModel> studentList = new List<StudentModel>();
            StudentModel student = new StudentModel();
            student.StudentID = 1;
            student.StudentName = "asdas";
            student.StudentClass = "a";
            studentList.Add(student);

            return View(studentList);
        }
    }
}