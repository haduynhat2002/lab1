using System;

namespace exercisee1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter address: ");
            var address = Console.ReadLine();
            Console.WriteLine("Please enter phone: ");
            var phone = Console.ReadLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Phone: " + phone);
        }
    }
}