using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    class Exception_Handling_04
    {

    public void trycatch()
    {
        try{
            int a = 1, b = 0;
            int c = a / b;
        }
        catch (Exception e)
        {
        Console.WriteLine(e.Message);
        }

        finally 
        {
            Console.WriteLine("finally block"); 
        }


        }

    }





}
