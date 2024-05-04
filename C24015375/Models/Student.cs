using C24015375.Interfaces;

namespace C24015375.Models
{
    // Base Student Class
    public class Student
    {
        // Properties
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public IAttendanceType AttendanceType { get; set; }
        public ILabType LabType { get; set; }

        // Constructor
        public Student(int studentID, string studentName, IAttendanceType attendanceType, ILabType labType)
        {
            StudentID = studentID;
            StudentName = studentName;
            AttendanceType = attendanceType;
            LabType = labType;
        }
    }
}
