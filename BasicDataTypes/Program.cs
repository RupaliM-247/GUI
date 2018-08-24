using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDatesAndTimes();
            Console.ReadLine();

            
        }


        static void UseDatesAndTimes()
        {
            Console.WriteLine("Date and times");
            DateTime dt = new DateTime(2015, 10, 17);

            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            dt = dt.AddMonths(2);

            Console.WriteLine("The date is {0}",dt.Date);

            Console.WriteLine("dayLight Savings Time {0}", dt.IsDaylightSavingTime());

            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);


            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();

         

        }


    }
}
