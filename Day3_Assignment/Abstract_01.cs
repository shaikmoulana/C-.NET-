using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    class Abstract_01
    {
    }

    abstract class AbstractClass {
        //----Abstract method------------------
        public abstract void AbMethod();

        //----Non - Abstract method------------------
        public void NonAbMethod()
        {
            Console.WriteLine("Non abstract method");
        }
    }

    class NormalClass : AbstractClass
    {
        public override void AbMethod()
        {
            Console.WriteLine("Abstarct method");
        }
    }


}
