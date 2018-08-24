using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee:Person
    {
        int empId;
        public Employee() :base()
        {
            Console.WriteLine(" cons enetr id");
            empId = int.Parse(Console.ReadLine());
        }
        public override void Accept()
        {
            Console.WriteLine("enter name:");
            name = Console.ReadLine();
            Console.WriteLine("enter age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter id:");
            empId = int.Parse(Console.ReadLine());

        }
        public override void display()
        {
            Console.WriteLine("name : {0} age:{1}  id : {2}",name,age,empId);
        }

    }
}
