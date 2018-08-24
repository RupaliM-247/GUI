using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Basic COnsole IO****");
            // GetUserData();
            //FormatNumericalData();
            //BasicStringFunctionality();
            //StringConcatenation();
            // EscapeChars();
            //StringImmutable();
            //FunWithStringBuilder();
            //DataTypeFunctionality();
            //CharFunctionality();
            //NewingDateTime();
            StringInterpolation();
            Console.ReadLine();
           
        }

        private static void GetUserData()
        {
            Console.Write("Please enter your name :");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age :");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello {0} you are {1} years old",userName,userAge);

            Console.ForegroundColor = prevColor;

        }

         static void FormatNumericalData()
        {
            Console.WriteLine("The value of 99999 in various formats");
            Console.WriteLine("c format : {0:c}", 99999);
            Console.WriteLine("d9 format : {0:d9}", 99999);
            Console.WriteLine("f3 format : {0:f3}", 99999);
            Console.WriteLine("n format : {0:n}", 99999);
            Console.WriteLine("E format : {0:E}", 99999);
            Console.WriteLine("e format : {0:e}", 99999);
            Console.WriteLine("X format : {0:X}", 99999);
            Console.WriteLine("x format : {0:x}", 99999);



        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("Basic string functionality");
            string firstName = "Freddy";
            Console.WriteLine("value of firstname : {0}", firstName);
            Console.WriteLine("firstname has {0} char", firstName.Length);
            Console.WriteLine("value of firstname upper  : {0}", firstName.ToUpper());
            Console.WriteLine("value of firstname  lower: {0}", firstName.ToLower());
            Console.WriteLine("fnmae contain letter y? : {0}", firstName.Contains("y"));
            Console.WriteLine("new fname: {0}", firstName.Replace("dy",""));
            Console.WriteLine();



        }

        static void StringConcatenation()
        {
            Console.WriteLine("string concat");
            string s1 = "\"prog the";
            string s2 = "psychodrill";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        static void EscapeChars()
        {
            Console.WriteLine("escape char :");
            string strWithtabs = "Model\tcolor\tspeed\tpet Name\a";
            Console.WriteLine(strWithtabs);

            Console.WriteLine("everyone loves \"Hello World\"\a");
            Console.WriteLine("C:\\Myapp\\bin\\Debug\a");
            Console.WriteLine(@"C:\Myapp\bin\Debug\a");
            Console.WriteLine("all finished.\n\n\n\a");
            Console.WriteLine(@"cerebus said ""hii i am here""");

         
            Console.WriteLine();
        }

        static void StringImmutable()
        {
            string s2 = "My first string";
            s2 = "my other string";
            Console.WriteLine(s2);
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("string builder");
            StringBuilder sb = new StringBuilder("*****Fantastic Games *****", 256);
            sb.Append("\n");
            sb.AppendLine("half life");
            sb.AppendLine("beyond good and evil");
            sb.AppendLine("deus ex 2");
            sb.AppendLine("system shock");
            Console.WriteLine(sb.ToString());
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("data type functionality");
            Console.WriteLine("max of int : {0}", int.MaxValue);
            Console.WriteLine("min of int : {0}", int.MinValue);
            Console.WriteLine("max of double : {0}", double.MaxValue);
            Console.WriteLine("min of double : {0}", double.MinValue);
            Console.WriteLine("double.epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.positiveinfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.negativeinfinity : {0}", double.NegativeInfinity);
            Console.WriteLine("bool.false : {0}", bool.FalseString);
            Console.WriteLine("bool.true : {0}", bool.TrueString);


        }

        static void CharFunctionality()
        {
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'):{0}", char.IsDigit(myChar));
            Console.WriteLine("char.isletter('a'):{0}", char.IsLetter(myChar));
            Console.WriteLine("char.iswhitespace: {0}", char.IsWhiteSpace("Hello there", 5));
            Console.WriteLine("char.iswhitespace: {0}", char.IsWhiteSpace("Hello there", 6));
            Console.WriteLine("char.ispunctuation('?') : {0}", char.IsPunctuation('?'));
            Console.WriteLine();
          


        }


        static void NewingDateTime()
        {
            Console.WriteLine("using new to create variables ");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0},{1},{2},{3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void StringInterpolation()
        {
            Console.Write("Please enter your name :");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age :");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

           string greeting = string.Format("\tHello {0} you are {1} years old", userName.ToLower(),userAge);
            Console.WriteLine(greeting);

            Console.WriteLine("using $ symbol, without using {0},{1}");

            Console.WriteLine($"\tHello {userName} you are {userAge} years old");

            Console.ForegroundColor = prevColor;
        }
    }
}
