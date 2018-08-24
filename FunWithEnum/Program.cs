using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnum
{
    enum EmpType : byte
    {
        Manager=10,
        Grunt=1,
        Contractor=100,
        VicePresident=9
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpType e = EmpType.Contractor;
            Console.WriteLine(e.ToString());
            byte a = (byte)e;
            Console.WriteLine(a);
            EmpType e1 = EmpType.Manager;
            AskForBonus(e1);
            Console.ReadLine();
        }

        static void AskForBonus(EmpType e)
        {
            switch(e)
            {
                case EmpType.Manager:
                    Console.WriteLine("how abt stock opt instead");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("you have got to be kidding");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("you already get enough cash");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, SIr!");
                    break;

            }
        }
    }
}
