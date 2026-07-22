using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.output
{
    class ConsuleShow : Ioutput
    {
        
        public void Output<T>(T counsuleInput)
        {
            Console.WriteLine(counsuleInput);


        }

    }
}
