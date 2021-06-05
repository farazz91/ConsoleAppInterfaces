using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    class Customer : ICustomer,ICustomer1
    {
        public void print()
        {
            Console.WriteLine("Implementing the print method from interface.");
        }
        public void PrintI2()
        {
            Console.WriteLine("Implementing the print method from second interface.");
        }
        //void ICustomer.PrintExp()
        public void PrintExp()  //making this as default
        {
            Console.WriteLine("Interface ICustomer method");
        }
        void ICustomer1.PrintExp()
        {
            Console.WriteLine("Interface ICustomer1 method");
        }
    }
}
