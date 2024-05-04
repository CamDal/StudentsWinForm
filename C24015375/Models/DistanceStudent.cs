using C24015375.Implementations;
using C24015375.Interfaces;

namespace C24015375.Models
{
    // Distance Student Class
    public class DistanceStudent : Student
    {
        public DistanceStudent(int studentID, string studentName, IAttendanceType attendanceType, ILabType labType)
            : base(studentID, studentName, attendanceType, labType)
        { }
    }
}
