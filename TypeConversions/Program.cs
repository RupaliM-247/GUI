using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("type conversions");

            Console.WriteLine("max of short : {0}", short.MaxValue);
            short num1 = 30000, num2 = 30000;
            try
            {
                short answer = (short)Add(num1, num2);
                Console.WriteLine("{0} + {1} = {2}", num1, num2, answer);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            unchecked
            {
                short answer = (short)Add(num1, num2);
                Console.WriteLine(" unchecked : {0} + {1} = {2}", num1, num2, answer);

            }
           // NarrowingAttempt();
            Console.ReadLine();
        }

        static int Add(int x,int y)
        {
            return x + y;

        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 300;
            myByte = (Byte)myInt;
            Console.WriteLine("value of myByte : {0}", myByte);
        }

        
         
    }
}
