using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCSConsoleApp
{
    class ForLoopDemo
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                    break;
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
