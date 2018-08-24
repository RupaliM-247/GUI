
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Employee1
    {
        public string name;

        public Employee1() {
            name = "citi";
            
         }

        public virtual void accept()
        {
            Console.WriteLine("enter name :");
            name = Console.ReadLine();


        }
        public virtual void display()
        {
            Console.WriteLine("name : {0}", name);

        }
    }
}
