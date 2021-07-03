using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryManagement.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public int SchoolGrade { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}