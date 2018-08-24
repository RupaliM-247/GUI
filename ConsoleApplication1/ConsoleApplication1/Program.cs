using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {
            int? x = null;
            try
            {
                Console.WriteLine("pls eneter marks if he was present else enter other key");
                x = int.Parse(Console.ReadLine());
                

            }
            catch(Exception )
            {
                x = null;
            }
            if(x!=null)
            {
                Console.WriteLine("marks for you are : {0}", x);
            }
            else
            {
                Console.WriteLine("you were absent for exam");

            }

            Console.ReadLine();



        }
    }


}
