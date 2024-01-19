using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("-----------01_class_and_object---------");
            Class_and_Object_01 classObj = new Class_and_Object_01();
            classObj.classobject();

     
            Console.WriteLine("-----------02_dataypes-------------");
            DataTypes_02 datatypeObj = new DataTypes_02();
            datatypeObj.datatypes();

            Console.WriteLine("-----------03_typecasting-----------");
            Typecasting_03 tcObj = new Typecasting_03();
            tcObj.imp();
            tcObj.exp();
            tcObj.typeConverstion();

            Console.WriteLine("-----------05_operators---------------");
            Operators_05 opObj = new Operators_05();
            opObj.operators();

            Console.WriteLine("-------------06_if-else--------------");
            If_Else_06 ifelseObj = new If_Else_06();
            ifelseObj.If_Else();

           // Console.WriteLine("-------------07_switch------------------");
           // Switch_07 swobj = new Switch_07();
           // swobj.switch_statemet();

            Console.WriteLine("-------------08_while------------------");
            While_08 wobj = new While_08();
            wobj.while_loop();

            Console.WriteLine("-------------09_for------------------");
            For_09 forObj = new For_09();
            forObj.For_loop();

            Console.WriteLine("-------------10_Arrays------------------");
            Arrays_10 arrObj = new Arrays_10();
            arrObj.arrays();

            Console.WriteLine("-------------11_Constructors------------------");
            Constructor constructorObj = new Constructor();
            constructorObj.DefaultConstructor();
            constructorObj.ParameterConstructor("Moulana",5961);

            Console.WriteLine("-------------12_Inheritence------------------");
            ChildClass ChildObj = new ChildClass();
            ChildObj.ParentMethod();
            ChildObj.ChildMethod();

            Console.WriteLine("-------------13_Polymerphism------------------");
            Console.WriteLine("--Overloading--");
            Overload1 olObj = new Overload1();
            olObj.add();
            olObj.add(10,20);
            Console.WriteLine("--Overridding--");
            Overriding orObj = new Overriding_Subclass();
            orObj.sub();


            Console.ReadLine();
        }
    }
}
