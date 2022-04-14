using System;

namespace TaskLoops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");

            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (n != 0) 
            {

                sum = sum + n % 10;

                n = n / 10;
            }

            Console.WriteLine("Sum of numbers are {0}",sum);
        }
    }
}
