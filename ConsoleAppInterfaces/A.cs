using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    class A : IA
    {
        public void PrintAMethod()
        {
            Console.WriteLine("Method A interface IA method.");
        }
    }
}
