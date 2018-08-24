using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyException
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader str = null; 
            try
            {
                str= new StreamReader(@"C:\Users\Grad57\Documents\Visual Studio 2015\Projects\MyException\doc.txt");
                Console.WriteLine(str.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("something went wrong {0}", ex.FileName);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("directory not found {0}", ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("in finally block");
                if(str!=null)
                {
                    str.Close();
                }
            }
            Console.WriteLine("out of finally block");
            Console.ReadLine();
        }
    }
}
