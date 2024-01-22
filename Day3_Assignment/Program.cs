using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Abstract_01---------------------------------");
            NormalClass NormalClassObj = new NormalClass();
            NormalClassObj.AbMethod();
            NormalClassObj.NonAbMethod();

            Console.WriteLine("------Interface_02---------------------------------");
            InterfaceClass interObj = new InterfaceClass();
            interObj.InterfaceMethod();

            Console.WriteLine("------Collections_03---------------------------------");
            collection colObj = new collection();
            colObj.listMethod();

            Console.WriteLine("------Exception handling_04---------------------------------");
            Exception_Handling_04 ExHObj = new Exception_Handling_04();
            ExHObj.trycatch();

            Console.WriteLine("------Files_05---------------------------------");
            Files_05 fileObj = new Files_05();
            fileObj.write();
            fileObj.read();

            Console.ReadLine();

        }
    }
}
