using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions { 

    public class Person
    {
        public int Age
        {
            get;
            set;

        }
        public string FirstName
        {
            get;
            set;

        }
        public string LastName
        {
            get;
            set;

        }

        public override string ToString()
        {
            return string.Format("Name : {0} {1}, Age : {2}", FirstName, LastName, Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person[] itemInPeople = new[] {
               new Person { FirstName = "rupali", LastName = "More", Age = 22 },
               new Person { FirstName = "citi", LastName = "corp", Age = 2 },
               new Person { FirstName = "nirmala", LastName = "convent", Age = 234 },
               new Person { FirstName = "Master", LastName = "Card", Age = 1 }
             };
            selectEverything(itemInPeople);
            ListPersonName(itemInPeople);
            GetOverAge(itemInPeople);
            GetNameAndAge(itemInPeople);
            GetCountFromQuery();
            Reverse(itemInPeople);
            AlphabetizeName(itemInPeople);
            DisplayDiff();
            Console.ReadLine();
        
        }

        static void selectEverything(Person[] people)
        {
            var allPeople = from p in people select p;         //select * from people
            foreach (var person1 in allPeople)
            {
                Console.WriteLine(person1.ToString());
            }

        }

        static void ListPersonName(Person[] people)
        {
            Console.WriteLine("only names");
            var peopleName = from p in people select p.FirstName;
            foreach (var name in peopleName.Reverse())
            {
                Console.WriteLine("name : {0}", name);
            }
        }

        static void GetOverAge(Person[] people)
        {
            Console.WriteLine("where clause");
            var personn = from p in people where p.Age > 21 select p;
            foreach (var person1 in personn)
            {
                Console.WriteLine(person1.ToString());
            }
        }

        static void GetNameAndAge(Person[] people)
        {
            Console.WriteLine("get name and age");
            var person = from p in people select new { p.FirstName, p.Age };
            //Console.WriteLine("for person : {0}",person.GetType().ToString());
            foreach (var person1 in person)
            {
                //Console.WriteLine("for each element in Perosn : {0}",person1.GetType().ToString());
                //could also use name and age prop directly
                Console.WriteLine("for each element in Perosn(direct tostring : {0}", person1.ToString());

            }

        }

        static void GetCountFromQuery()
        {
            string[] currVideoGames = { "MorrowWind", "Uncharted 2 ", "Fallout 3", "Daxter", "System SHock" };
            int num = (from g in currVideoGames where g.Length > 6 select g).Count();
            Console.WriteLine("{0} items honor the LINQ query", num);
        }

        static void Reverse(Person[] people)
        {
            var allPeople = from p in people select p;         //select * from people
            foreach (var person1 in allPeople.Reverse())
            {
                Console.WriteLine(person1.ToString());
            }

        }

        static void AlphabetizeName(Person[] people)
        {
            var allPeople = from p in people orderby p.FirstName select p;         //select * from people
            Console.WriteLine("order by name");
            foreach (var person1 in allPeople)
            {
                Console.WriteLine(person1.ToString());
            }

        }

        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);
            foreach(string diff in carDiff)
            {
                Console.WriteLine(diff);
            }

        }







    }
}

