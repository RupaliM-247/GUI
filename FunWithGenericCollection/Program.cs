using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunWithGenericCollection
{
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
            return string.Format("Name : {0} {1}, Age : {2}",FirstName,LastName,Age);
        }
    }

    class SortPeopleByAge: IComparer<Person>
    {
        public int Compare(Person firstPerson,Person secondPerson)
        {
            if (firstPerson.Age >= secondPerson.Age)
                return 1;
            if (firstPerson.Age < secondPerson.Age)
                return -1;
            else
                return 0;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            // UseGenericList();
            // UseGenericQueue();
            // UseGenericStack();
            // UseSortedSet();
            UseDictionary();
            Console.ReadLine();
        }

        private static void UseGenericList()
        {
            List<Person> people = new List<Person>() {
            new Person { FirstName="Rupali",LastName="More",Age=22 },
            new Person { FirstName = "Shahrukh", LastName = "Khan", Age = 50 },
            new Person { FirstName = "Rohan", LastName = "More", Age = 24 },
            new Person { FirstName = "Usha", LastName = "More", Age = 48 }
            };
            Console.WriteLine("Number of elements in the list  {0}:",people.Count);
            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }



            people.Insert(2, new Person { FirstName = "citi", LastName = "Corp", Age = 200 });
            Console.WriteLine("\nafter adding one element");
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("copying data to array");
            Person[] arrayOfPeople = people.ToArray();
            foreach(Person p in arrayOfPeople)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("\nafter removing one element");
            people.RemoveAt(1);
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
        }

        static void UseGenericQueue()
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Rupali", LastName = "More", Age = 22 });
            peopleQ.Enqueue(new Person { FirstName = "citi", LastName = "corp", Age = 24 });
            peopleQ.Enqueue(new Person { FirstName = "Master", LastName = "Card", Age = 26 });

            Console.WriteLine("{0} is first in line", peopleQ.Peek().FirstName);

            /*(GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());*/
            peopleQ.Dequeue();
            peopleQ.Dequeue();
            peopleQ.Dequeue();

            try
            {
                peopleQ.Dequeue();
            }
            catch(Exception e)
            {
                Console.WriteLine("Queue is empty");

            }


        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Rupali", LastName = "More", Age = 22 });
            stackOfPeople.Push(new Person { FirstName = "citi", LastName = "corp", Age = 24 });
            stackOfPeople.Push(new Person { FirstName = "Rupaliiii", LastName = "Moreee", Age = 26 });
            Console.WriteLine("first person is : {0}", stackOfPeople.Peek());
            Console.WriteLine("popped of {0}", stackOfPeople.Pop());
            Console.WriteLine("first person is : {0}", stackOfPeople.Peek());
            Console.WriteLine("popped of {0}", stackOfPeople.Pop());
            Console.WriteLine("first person is : {0}", stackOfPeople.Peek());
            Console.WriteLine("popped of {0}", stackOfPeople.Pop());
           try
            {
                Console.WriteLine("first person is : {0}", stackOfPeople.Peek());
                Console.WriteLine("popped of {0}", stackOfPeople.Pop());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
               new Person { FirstName="rupali",LastName="More",Age=22},
               new Person { FirstName="citi",LastName="corp",Age=2},
               new Person { FirstName="nirmala",LastName="convent",Age=234},
               new Person { FirstName="Master",LastName="Card",Age=1}


            };
            foreach(Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }

            setOfPeople.Add(new Person { FirstName = "rupalii", LastName = "Moree", Age = 22});
            Console.WriteLine("\nafter adding one element \n");
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }

        private static void UseDictionary()
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("rupali", new Person { FirstName = "rupali", LastName = "More", Age = 22 });
            peopleA.Add("citi", new Person { FirstName = "citi", LastName = "More", Age = 24 });
            peopleA.Add("Master", new Person { FirstName = "Master", LastName = "More", Age = 26 });

            Person rupali = peopleA["rupali"];
            Console.WriteLine(rupali);

            Dictionary<string, Person> peopleB = new Dictionary<string, Person>() {
            { "rupali", new Person { FirstName = "rupali", LastName = "More", Age = 22 } },
            { "citi", new Person { FirstName = "citi", LastName = "More", Age = 24 } },
            { "Master", new Person { FirstName = "Master", LastName = "More", Age = 26 } },
        };

            Person citi = peopleB["citi"];
            //change age value of citi
            citi.Age = 34;
            Console.WriteLine(citi);



        }




    }
}
