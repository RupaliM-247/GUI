using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.getEmployeeDetails();
            emp.displayEmployeeDetails();
            Console.ReadLine();
            /* Employee1 emp = new Employee1();
             emp.accept();
             emp.display();

             Employee1 emp1 = new DirectEmployee();
             emp1.accept();
             emp1.display();

             Employee1 emp2 = new ContractEmployee();
             emp2.accept();
             emp2.display();


             Employee1 p;
             Console.WriteLine("enter 1:Employee \n2:DirectEmmployee\n3:ContractEmployee");
             int choice = int.Parse(Console.ReadLine());
             switch(choice)
             {
                 case 1:
                     p = new Employee1();
                     break;
                 case 2:
                     p = new DirectEmployee();
                     break;
                 case 3:
                     p = new ContractEmployee();
                     break;
                 default:
                     p = new Employee1();
                     break;
             }
             p.accept();
             p.display();











             // C c = new C();

             // Employee emp = new Employee();


             // emp.getEmployeeDetails();
             //emp.displayEmployeeDetails();

             /*Employee emp1 = new Employee("rupa","anand",12,345,567);
             emp1.displayEmployeeDetails();

             emp1.getEmployeeDetails("rupa", "anan", 1, 34, 56);
             emp1.displayEmployeeDetails();
             Console.WriteLine();
             Console.ReadLine();*/
            /* Employee[] e = new Employee[5];


             string exit;

             for (int i = 0; i < e.Length; i++)
             {
                 e[i] = new Employee();



                  do
                  {

                      Console.WriteLine("Enter your choice : \n1 :get employee details\n2 :display details\n");
                      string choice = Console.ReadLine();
                      int Choice = int.Parse(choice);


                      switch (Choice)
                      {
                          case 1:
                              e[i].getEmployeeDetails();
                              break;
                          case 2:
                              e[i].displayEmployeeDetails();
                              break;
                          default:
                              Console.WriteLine("Sorry, you have entered incorrect choice");
                              break;
                      }
                      Console.WriteLine("do you want to exit: yes or no");
                      exit = Console.ReadLine();


                  } while (exit != "yes");
                 if (exit == "yes")
                 {
                     break;
                 }
             }

             Console.WriteLine("display allll");


             Console.WriteLine("byeee");*/


        }
    }
}
