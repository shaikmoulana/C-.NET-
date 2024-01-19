using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignments
{
    class Constructor
    {
        string name;
        int id;

        public void DefaultConstructor() 
            {
                Console.WriteLine("Without Parameters");

            }

        public void ParameterConstructor(string name, int id)
        {
            Console.WriteLine("With Parameters");
            this.name = name;
            this.id = id;
        }


    }
}
 