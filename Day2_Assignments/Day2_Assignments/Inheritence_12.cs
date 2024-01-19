using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignments
{
    class Inheritence_12
    {
        public void ParentMethod()
        {
            Console.WriteLine("this is a parent method");
        }
    }
    
    class ChildClass : Inheritence_12
    {
        public void ChildMethod()
        {
            Console.WriteLine("this is a child method");
        }
    }

}