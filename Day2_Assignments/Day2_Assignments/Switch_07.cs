using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignments
{
    class Switch_07
    {
        public void switch_statemet()
        {
            int task =Convert.ToInt32( Console.ReadLine());
            switch (task)
            {
                case 1:
                    Console.WriteLine("withdraw");
                    break;
                case 2:
                    Console.WriteLine("deposite");
                    break;
                case 3:
                    Console.WriteLine("check balance");
                    break;
                case 4:
                    Console.WriteLine("exit");
                    break;
                default:
                    Console.WriteLine("Wrong entry");
                    break;
            }
        }
    }
}
