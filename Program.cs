using System;

namespace TicketsPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age = default(uint);
            bool isStudent = default(bool);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Enter age: ");
                try
                 {
                     age = UInt32.Parse(Console.ReadLine());
                     break;
                 }
                 catch (System.OverflowException)
                 {
                     Console.WriteLine($"Enter a positive age.");
                 }
                 catch (System.FormatException)
                 {
                     Console.WriteLine($"Enter a number.");
                 }
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Are you a student? [y/n]");
                var studentString = Console.ReadLine();
                if(studentString.Equals("y",StringComparison.OrdinalIgnoreCase)){
                    isStudent = true;
                    break;
                }
                else if(studentString.Equals("n",StringComparison.OrdinalIgnoreCase)){
                    isStudent = false;
                    break;
                }
                else{
                    Console.WriteLine("Please enter valid input.");
                }
            }
            
            if(age < 13 || isStudent) {
                Console.WriteLine("Your ticket costs $8");
            }
            else if(age < 65) {
                Console.WriteLine("Your ticket costs $14");
            }
            else {
                Console.WriteLine("Your ticket costs $10");
            }

        }
    }
}
