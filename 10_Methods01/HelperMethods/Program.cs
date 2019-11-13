using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.WriteLine("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("In what city were you born? ");
            string city = Console.ReadLine();


            // 2. Method
            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));

            Console.WriteLine();

            // Overrided 2. Method
            DisplayResult(ReverseString(firstName) + " " +
                ReverseString(lastName) + " " + 
                ReverseString(city));

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        // 2. Method
        public static void DisplayResult(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.WriteLine("Results: ");
            Console.WriteLine(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

        // Overrided of 2. Method
        private static void DisplayResult(string message)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine(message);
        }

    }
}
