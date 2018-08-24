using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class ContractEmployee:Employee1
    {
        public int empid;
        public ContractEmployee():base()
        {
            empid = 30;

        }
        public override void accept()
        {
            
            Console.WriteLine("enter id :");
            empid = int.Parse(Console.ReadLine());
            base.accept();

        }
        public override void display()
        {
            Console.WriteLine("empid : {0}", empid);
            base.display();

        }
    }
}
