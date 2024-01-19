using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignments
{
    class Typecasting_03
    {
        int id = 5961;
        string name = "moulana";
        char blockName = 'A';
        float salary = 20000.56f;
        double phoneNo = 1234567890;
        bool details = true;


        //-----implicit---------
        public void imp()
        {
            double d = id;
            Console.WriteLine(id);
            Console.WriteLine(d);
        }

        //-----explicit---------
        public void exp()
        {
        int i = (int)phoneNo;    
            Console.WriteLine(i);
        }

        public void typeConverstion() {
            Console.WriteLine(Convert.ToString(details));
            Console.WriteLine(Convert.ToDouble(id));
            Console.WriteLine(Convert.ToInt32(salary));
            Console.WriteLine(Convert.ToString(blockName));
        }
    }
}
