using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    class CustomerAC : AbstractCustomer
    {
        public override void printAC()
        {
            Console.WriteLine("Abstatact method implementation.");
        }
    }
    //This class can also be make abstarct using abstract key work if dont want to impletent the methods.
    //abstract class CustomerAC : AbstractCustomer
    //{
    //    string str = "";
    //}
}
