using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCTest.Models.Student
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentClass { get; set; }

        public List<StudentModel> studentModels { get; set; }
        public StudentModel()
        {

        }
        public StudentModel(StudentModel _student)
        {
            StudentID = _student.StudentID;
            StudentName = _student.StudentName;
            StudentClass = _student.StudentClass;
        }
    }
}
