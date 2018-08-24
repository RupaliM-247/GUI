using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllInventory();
            Console.ReadLine();
        }
        private static void PrintAllInventory( )
        {
            using(var context = new EF.Model1())
            {
                foreach (EF.Department c in context.Departments.SqlQuery("Select * from Department"))
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
