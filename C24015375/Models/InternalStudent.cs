using C24015375.Implementations;
using C24015375.Interfaces;

namespace C24015375.Models
{
    // Internal Student Class
    public class InternalStudent : Student
    {
        public InternalStudent(int studentID, string studentName, IAttendanceType attendanceType, ILabType labType)
            : base(studentID, studentName, attendanceType, labType)
        {
         
        }
    }
}
