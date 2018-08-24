using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
   class A
    {

        public  A()
        {
            Console.WriteLine("A cons");

        }
        ~A()
        {
            Console.WriteLine("A des");

        }
    }
}
