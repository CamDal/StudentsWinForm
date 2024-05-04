using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C24015375.Interfaces;

namespace C24015375.Implementations
{
    // Online attendance type strategy
    public class OnlineAttendance : IAttendanceType
    {
        public string GetAttendanceType()
        {
            return "On-line";
        }
    }

}
