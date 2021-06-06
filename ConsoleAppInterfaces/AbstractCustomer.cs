using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    abstract class AbstractCustomer
    {
        public Guid Id { get; set; }

        public abstract void printAC();

        public void PrintCustomerDetail()
        {
            Console.WriteLine("Id : {0}",Id);
        }
        public AbstractCustomer()
        {            
            this.Id = Guid.NewGuid();
        }
    }
}
