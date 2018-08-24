using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class DirectEmployee : Employee1
    {
        public int age;

        public DirectEmployee():base()
        {
            age = 22;

        }
        public override void accept()
        {

            Console.WriteLine("enter age :");
            age = int.Parse(Console.ReadLine());
            base.accept();


        }

      
        public override void display()
        {
            base.display();
            Console.WriteLine("age : {0}",age);

        }
    }
}
