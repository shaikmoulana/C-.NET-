using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    class Interface_02
    {
    }

    interface Interface {
        void InterfaceMethod();
    }

    class InterfaceClass : Interface {
    
        public void InterfaceMethod()
        {
            Console.WriteLine("Interface method ");
        }
    }



}
