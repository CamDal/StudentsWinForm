using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C24015375.Interfaces;

namespace C24015375.Implementations
{
    // Online lab type strategy
    public class CloudLabType : ILabType
    {
        public string GetLabType()
        {
            return "Use the Cloud";
        }
    }

}
