using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeQuiz.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public string Position { get; set; }
        public double Wange { get; set; }
        public char Sex { get; set; }
        public string PhotoPath { get; set; }
    }
}