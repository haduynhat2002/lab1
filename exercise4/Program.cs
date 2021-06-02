using System;

namespace exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter (1->9): ");
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n*i);
            }
        }
    }
}