using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)

        {

            /*int x = 9, y = 10;
            Console.WriteLine("before call : x : {0} and y : {1} ", x, y);
            swapnorm(x, y);
            swap(ref x, ref y);
            Console.WriteLine("after call : x : {0} and y : {1} ", x, y);*/
            int ans;
            Add(out ans,90,90);
            Console.WriteLine("90+90={0}", ans);
            Console.ReadLine();
        }

        static void swapnorm(int x,int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("values after swap in swap fn x : {0} and y : {1}", x, y);
            Console.WriteLine();

        }
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("values after swap in swap fn x : {0} and y : {1}", x, y);
            Console.WriteLine();

        }

        static void Add(out int ans, int x = 100, int y = 100)
        {
            ans = x + y;
        }



    }
}
