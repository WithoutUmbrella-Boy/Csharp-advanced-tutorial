using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_多播委托
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("Test1");
        }

        static void Test2()
        {
            Console.WriteLine("Test2");
        }

        static void Main(string[] args)
        {
            //多播委托，引用多个方法的委托为多播委托
            Action a = Test1;
            a += Test2;//表示添加一个委托的引用

            //a -= Test1;
            //a -= Test2;


            //if (a!=null)
            //a();//当一个委托没有指向任何方法的时候，调用的话会出现异常null

            Delegate[] delegates = a.GetInvocationList();
            foreach (Delegate de in delegates)
            {
                de.DynamicInvoke();
            }

            Console.ReadKey();
        }
    }
}
