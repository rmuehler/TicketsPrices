using System;

namespace TicketsPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age;
            bool isStudent;

            Console.WriteLine("Enter age: ");
            try
            {
                age = UInt32.Parse(Console.ReadLine());
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Enter a correct age.");
            }
        }
    }
}
