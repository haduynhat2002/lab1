using System;

namespace exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            var number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1 +" is the largest number.");
            } else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine(number2 +" is the largest number.");
            }
            else
            {
                Console.WriteLine(number3 +" is the largest number.");
            }
        }
    }
}