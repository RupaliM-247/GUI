using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class C:B
    {
        public  C()
        {
            Console.WriteLine("C cons");

        }
        ~C()
        {
            Console.WriteLine("C des");

        }
    }
}
