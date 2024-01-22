using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    class Files_05
    {
        public void write()
        {
            string data = "hello world";
            File.WriteAllText("C:\\Users\\mshaik5\\source\\repos\\Day3_Assignment\\file1.txt", data);
        }

        public void read()
        {
            string read = File.ReadAllText("C:\\Users\\mshaik5\\source\\repos\\Day3_Assignment\\file1.txt");
            Console.WriteLine(read);
            
        }

       /* public void delete()
        {
            File.Delete("C:\\Users\\mshaik5\\source\\repos\\Day3_Assignment\\file1.txt");
        }*/

    }
}
