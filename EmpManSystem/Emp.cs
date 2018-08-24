using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManSystem
{
    class Program
       
    {
        static string name = "rupali";
        static string address= "anand plaza";
        static int age = 22;
        static long phone= 9876543210;
        static long salary=90000;
        static DateTime dob = new DateTime(1995,12,07);



        static void Main(string[] args)
        {

            string exit;
           
            do
            {

                Console.WriteLine("Enter your choice : \n1 :get employee details\n2 :display details\n");
                string choice = Console.ReadLine();
                int Choice = int.Parse(choice);
                switch (Choice)
                {
                    case 1:
                        getEmployeeDetails();
                        break;
                    case 2:
                        displayEmployeeDetails();
                        break;
                    default:
                        Console.WriteLine("Sorry, you have entered incorrect choice");
                        break;
                }
                Console.WriteLine("do you want to exit: yes or no");
                exit = Console.ReadLine();

            } while (exit != "yes");

    
        }

        static void getEmployeeDetails()
        {
            Console.WriteLine("enter the name of employee :");
            name = Console.ReadLine();
            Console.WriteLine("enter the address of employee :");
            address = Console.ReadLine();
agee:            Console.WriteLine("enter the age of employee :");
            string age1 = Console.ReadLine();
            bool x =  int.TryParse(age1,out age);
            if(x)
            {
                Console.WriteLine("success");
            }
           else
            {
                Console.WriteLine("failed to convert");
                goto agee;
            }
           
           
            Console.WriteLine("enter the phone no of employee :");
            string phone1 = Console.ReadLine();
            phone = long.Parse(phone1);
            Console.WriteLine("enter the salary of employee :");
            string sal1 = Console.ReadLine();
            salary = long.Parse(sal1);
            Console.WriteLine("Please enter the date of birth in year/month/day format");
            string date = Console.ReadLine();

            dob = DateTime.Parse(date);
            
           




        }

        static void displayEmployeeDetails()
        {

            Console.WriteLine("employee details :");
            Console.WriteLine("name of emp : {0}",name);
            Console.WriteLine("address of emp : {0}",address);
            Console.WriteLine("age of emp : {0}",age);
            Console.WriteLine("phone no  of emp  {0}:",phone);
            Console.WriteLine("salary of emp : {0}",salary);
            Console.WriteLine("dob : {0}", dob.Date);

        }
    }
}
