using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    class AB : IA,IB
    {
        A a = new A();
        B b = new B();

        public void PrintAMethod()
        {
            a.PrintAMethod();
        }

        public void PrintBMethod()
        {
            b.PrintBMethod();
        }
    }
}
