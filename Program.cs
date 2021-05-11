using System;

namespace TicketsPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age = default(uint);
            bool isStudent = default(bool);

            Console.WriteLine("Enter age: ");
            try
            {
                age = UInt32.Parse(Console.ReadLine());
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine($"Enter a positive age.");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine($"Enter a number.");
            }

            Console.WriteLine("Are you a student? [y/n]");
            var studentString = Console.ReadLine();
            if(studentString.Equals("y",StringComparison.OrdinalIgnoreCase)){
                isStudent = true;
            }
            else if(studentString.Equals("n",StringComparison.OrdinalIgnoreCase)){
                isStudent = false;
            }
            else{
                Console.WriteLine("Please enter valid input.");
                
            }

            if(age < 13 || isStudent) {
                Console.WriteLine("Your ticket costs $8");
            }
            else if(age >= 13 && age < 65) {
                Console.WriteLine("Your ticket costs $14");
            }
            else {
                Console.WriteLine("Your ticket costs $10");
            }

        }
    }
}
