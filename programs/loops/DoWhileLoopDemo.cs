using System;

namespace TestCSConsoleApp
{
    class DoWhileLoopDemo
    {
        static void Main()
        {
            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);
            Console.ReadKey();
        }
    }
}
