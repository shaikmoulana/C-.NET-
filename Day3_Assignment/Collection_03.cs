using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    class Collection_03
    {
    }

    class collection
    {
        public void listMethod()
        {
            List<string> ls = new List<string>();
            ls.Add("Moulana");
            ls.Add("Chaithu");
            ls.Add("Mukesh");
            ls.Add("Kumar");
            foreach (var i in ls)
            {
                Console.WriteLine(i);
            }
        }
    }

    }
