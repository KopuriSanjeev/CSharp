using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCSConsoleApp
{
    class WhileLoopDemo
    {
        static void Main()
        {
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.Read();
        }
    }
}
