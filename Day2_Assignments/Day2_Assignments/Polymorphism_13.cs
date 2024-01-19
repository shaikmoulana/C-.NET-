using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignments
{
    class Polymorphism_13
    {
    }
    //----------OverLoading----------------------
    public class Overload1
    {
        int a=2, b=3;
        public void add()
        {
            Console.WriteLine(a + b);
        }
        public void add(int x,int y)
        {
            Console.WriteLine(x + y);
        }
    }

    //------Overriding-----------------------------------
    public class Overriding {
        
        public virtual void sub(int a = 100,int b = 200)
        {
            Console.WriteLine(b-a +" super class method" );
        } 

    }

    public class Overriding_Subclass:Overriding
    {
        public override void sub(int a = 100,int b = 200)
        {
            Console.WriteLine(b-a+" sub class method");
        }

    }




}
