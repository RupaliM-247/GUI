using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("loops and choices");
            ForAndForEachLoop();
            VarInForEachLoop();
            ExecuteWhileLoop();
            ExecuteDoWhileLoop();
            ExecuteIfElse();
            ExecuteSwitch();
            ExecuteSwitchOnString();
            SwitchOnEnumExample();
            Console.ReadLine();


        }

        static void ForAndForEachLoop()
        {
            for(int i=0;i<4;i++)
            {
                Console.WriteLine("Numner is : {0}", i);
            }
            Console.WriteLine();

            string[] carTypes = { "ford", "BMW", "Yugo", "Honda" };
            foreach(string c in carTypes)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine();

            int[] myInts = { 10, 20, 30, 40 };
            foreach(int i in myInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


        }


        static void VarInForEachLoop()
        {
            int[] myInts = { 10, 20, 30, 40 };
            foreach (var item in myInts)
            {
                Console.WriteLine("Item value : {0}",item);
            }
            Console.WriteLine();



        }

        static void ExecuteWhileLoop()
        {
            string userIsDone = "";
            while(userIsDone.ToLower() != "yes") 
            {
                Console.WriteLine("are you done ? [yes] [no] ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("in while loop");


            }
            Console.WriteLine();


        }

        static void ExecuteDoWhileLoop()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("do while loop");
                Console.WriteLine("are you done ? [yes] [no] ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("in while loop");

            } while (userIsDone.ToLower() != "yes");
            Console.WriteLine();
           
        }

        static void ExecuteIfElse()
        {
            string stringData = "my textual data";
            if(stringData.Length>0)
            {
                Console.WriteLine("string is greater than 0 chars");

            }
            Console.WriteLine();
        }

        static void ExecuteSwitch()
        {

            Console.WriteLine("1 [c#] 2 [VB]");
            Console.WriteLine("please pick up your language preference");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
           switch(n)
            {
                case 1:
                    Console.WriteLine("C# is a fine language");
                    break;
                case 2:
                    Console.WriteLine("VB:OOP,multithreading, and more");
                    break;
                default:
                    Console.WriteLine("well good luck with that");
                    break;
            }
            Console.WriteLine();


        }
         static void  ExecuteSwitchOnString()
        {

            Console.WriteLine("C# or VB");
            Console.WriteLine("please pick up your language preference");
            string langChoice = Console.ReadLine();
         
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("C# is a fine language");
                    break;
                case "VB":
                    Console.WriteLine("VB:OOP,multithreading, and more");
                    break;
                default:
                    Console.WriteLine("well good luck with that");
                    break;
            }
            Console.WriteLine();

        }

        static void SwitchOnEnumExample()
        {
            Console.WriteLine("enter your fav day");
            DayOfWeek favDay;
            try
            {
               favDay=  (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("bad input");
                return;
            }

            switch(favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("yes friday rocks");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("another monday");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("yayy sat");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("sunday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("tues");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("wed");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("thursday");
                    break;
            }
            Console.WriteLine();
        }
           
        
     
    }
}
