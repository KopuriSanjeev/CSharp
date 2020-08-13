using System;

namespace TestCSConsoleApp
{
    // This program is used to take number from user and
    // display whether it is Prime number or not
    class PrimeNumberDemo
    {
        static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count == 0)
                Console.WriteLine("Given number " + n + " is an Prime number");
            else
                Console.WriteLine("Given number " + n + " is not an Prime number");
            Console.ReadLine();
        }


    }
}
