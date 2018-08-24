using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Thread Slave = new Thread(funWithThread);
            Slave.Start();
            Console.WriteLine("hello world again!");
            Console.ReadLine();

        }

        static void funWithThread()
        {
            Thread.Sleep(10000);
            Console.WriteLine("This is in thread");
        }
    }
}
