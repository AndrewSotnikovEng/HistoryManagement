using HistoryManagement.Models;
using HistoryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace HistoryManagement.Controllers
{
    public class StudentController : ApiController
    {
        StudentDBContext context = new StudentDBContext();

        // GET api/student
        public IEnumerable<Student> Get()
        {
            
            return (IEnumerable<Student>)context.Students.ToList();
        }

        
        public string Post(Student s)
        {
            context.Students.Add(s);
            context.SaveChanges();

            return $"Added {s}";
        }

        [Route("api/students/edit")]
        public string Post(int StudentID, Student s)
        {
            Student oldStudent =  context.Students.Find(StudentID);
            Student newStudent = context.Students.Find(StudentID);

            newStudent.FirstName = s.FirstName;
            newStudent.LastName = s.LastName;
            newStudent.Age = s.Age;
            newStudent.SchoolGrade = s.SchoolGrade;

            context.SaveChanges();

            return $"Replaced {oldStudent} => {newStudent}";

        }

        //context.Students.Add(new Models.Student
        //    {
        //        FirstName = "Andrii",
        //        LastName = "Sotnikov",
        //        Age = 32,
        //        SchoolGrade = 80
        //    });
        //    context.SaveChanges();
        //    return new string[] { "value1", "value2" };


    }
}