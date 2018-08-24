using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string name;
        public int age;
       
        public Person()
        {
            Console.WriteLine("cons enter name:");
            name = Console.ReadLine();
            Console.WriteLine("cons enter age:");
            age = int.Parse(Console.ReadLine());
         
        }
        public virtual void Accept()
        {
            Console.WriteLine("enter name:");
            name = Console.ReadLine();
            Console.WriteLine("enter age:");
            age = int.Parse(Console.ReadLine());
           

        }
        public  virtual void display()
        {
            Console.WriteLine("name : {0} age : {1}", name,age);

        }
    }
}
