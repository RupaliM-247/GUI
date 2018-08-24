using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        delegate int del(int i);
        static void Main(string[] args)
        {
            del myDelegate = y => y / y;        //y=>y*y is lambda expression
            myDelegate += square;
            myDelegate += add;

            myDelegate += delegate (int x)
            {
                Console.WriteLine("anonymous func called");
                return x * x;
            };

            int j = myDelegate(5);
            Console.WriteLine(j);
            Console.ReadLine();
        }
       public static int square(int num)
        {
            Console.WriteLine("square called");
            return num*num;
        }
        public static int add(int num)
        {
            Console.WriteLine("add called");
            return num + num;
        }
    }
}
