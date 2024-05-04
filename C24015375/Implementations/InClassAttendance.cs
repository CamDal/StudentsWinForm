using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C24015375.Interfaces;

namespace C24015375.Implementations
{
    // In-class lab type strategy
    public class InClassAttendance : IAttendanceType
    {
        public string GetAttendanceType()
        {
            return "In-class";
        }
    }
}
