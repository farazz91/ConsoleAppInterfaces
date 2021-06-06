using System;

namespace ConsoleAppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Cust = new Customer();
            Cust.print();
            Cust.PrintI2();
            Console.WriteLine();

            //Explicit calling of interface
            Console.WriteLine("Explicit calling of interface method 1");
            Customer cust1 = new Customer();
            ((ICustomer)cust1).PrintExp();
            ((ICustomer1)cust1).PrintExp();
            Console.WriteLine();

            Console.WriteLine("Explicit calling of interface method 2");
            ICustomer icust = new Customer();
            ICustomer1 icust1 = new Customer();

            icust.PrintExp();
            icust1.PrintExp();

            Console.WriteLine();
            Console.WriteLine("Default interface by implementing one method normally.");
            Cust.PrintExp();

            Console.WriteLine();
            Console.WriteLine("Abstract Class.");
            CustomerAC custac = new CustomerAC();
            custac.printAC();

            //cn use refernece but cannot create an direct instance
            Console.WriteLine();
            AbstractCustomer abscust = new CustomerAC();
            abscust.printAC();

            //Constructor for abstract class
            CustomerAC constabs = new CustomerAC();
            Console.WriteLine("Customer ID: {0}",constabs.Id.ToString());

            CustomerAC constabs1 = new CustomerAC();
            Console.WriteLine("Customer1 ID: {0}", constabs1.Id.ToString());
        }
    }
}
