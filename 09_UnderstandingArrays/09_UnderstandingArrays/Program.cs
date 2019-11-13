using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare Array of 5 numbers
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;

            // Display second number in Array
            Console.WriteLine(numbers[1]);
            // Display Length(how many items in array) 
            Console.WriteLine(numbers.Length);


            // Example 2. - Declare and initialize Array
            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 }; 

            // Example 3. 
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            // Foreach is quicker
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            // Example 4. - Reverse Array
            string zig = "You can get what you want out of life" +
                "if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }

            Console.ReadLine();
        }
    }
}
