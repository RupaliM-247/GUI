using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class B:A
    {


       public  B()
        {
            Console.WriteLine("B cons");

        }
        ~B()
        {
            Console.WriteLine("B des");

        }
    }
}
