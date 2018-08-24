using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleArray();
            //ArrayInitialization();
            //DeclareImplicitArrays();
            // ArrayOfObjects();
            //RectMultidimensionalArray();
            //JaggedArrays();
            // PassAndReceiveArrays();
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        static void SimpleArray()
        {
            int[] myInts = new int[3];
            myInts[0]=20;
            myInts[1] = 30;
            myInts[2] = 40;
            foreach(int x in myInts)
            {
                Console.WriteLine("array element : {0}", x);
            }

        }
        static void ArrayInitialization()
        {
            string[] stringArray = new string[] { "abc", "xyz", "sfd" };
            Console.WriteLine("str array has {0} elements", stringArray.Length);
            int[] intArray = new int[4] { 10, 20, 30,40 };
            Console.WriteLine("bool array has {0} elements", intArray.Length);
            bool[] boolArray = { true, false, true };
            Console.WriteLine("int array has {0} elements", boolArray.Length);
            Console.WriteLine();

        }

        static void  DeclareImplicitArrays()
        {
            Console.WriteLine("implicit array");
            var a = new[] { 10, 20, 30, 40 };
            Console.WriteLine("a is a : {0}", a.ToString());
            var b = new[] { 1, 1.5, 2 };
            Console.WriteLine("b is b : {0}", b.ToString());
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is c : {0}", c.ToString());
        }

        static void ArrayOfObjects()
        {
            object[] myObjects = new object[4];
            myObjects[0] = true;
            myObjects[1] = 3.4;
            myObjects[2] = "hello";
            myObjects[3] = new DateTime(1987, 12, 3);
            foreach(object obj in myObjects)
            {
                Console.WriteLine("type : {0}  Value : {1}", obj.GetType(),obj);
            }
            Console.WriteLine();
        
                
         }

        static void RectMultidimensionalArray ()
        {
            Console.WriteLine("multi dim array ");
            int[,] myMatrix = new int[3, 4];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++)
                {
                    myMatrix[i, j] = i * j;
                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
   
            }
            Console.WriteLine();

        }

        static void JaggedArrays()
        {

            int[][] myJagArray = new int[5][];
            for(int i=0;i<myJagArray.Length;i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            for(int i=0;i<myJagArray.Length;i++)
            {
                for(int j=0;j<myJagArray[i].Length;j++)
                {
                    Console.Write(myJagArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

      
        static void PrintArray(int[] myInts)
        {

            for(int i=0;i<myInts.Length;i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "hello", "from", "getstring" };
            return theStrings;//
        }
        static void PassAndReceiveArrays()
        {

            int[] ages = { 20, 30, 40, 50 };
            PrintArray(ages);
            string[] strs = GetStringArray();
            foreach(string s in strs)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }

        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("working with System.array");
            string[] gothicBands = { "tones on tail", "Bauhaus", "Sisters of Mercy" };
            Console.WriteLine("here is the array");
            for(int i=0;i<gothicBands.Length;i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Array.Reverse(gothicBands);
            Console.WriteLine("here is the reversed  array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("cleared all but one");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }


            Console.WriteLine();
        }






    }
}
