using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C24015375.Models
{
    using System.Collections.Generic;

    public class University
    {
        // Singleton Instance
        private static University instance;

        private University() { }

        // Singleton Instance Property
        public static University Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new University();
                }
                return instance;
            }
        }

        // List of Students
        public List<Student> Students { get; set; } = new List<Student>();

        // Method to Add a Student
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }

}
