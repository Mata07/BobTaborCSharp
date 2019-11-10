using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //If Decisions

            //Console.WriteLine("Bob's Big Giveaway!");
            //Console.Write("Choose a door: 1, 2 or 3: ");
            //string userValue = Console.ReadLine();

            //string message = "";

            ////1. short way of if statement, if it's just one line! 
            //if (userValue == "1")
            //    message = "You won a new car!";
            //else if (userValue == "2")
            //    message = "You won a new boat!";
            //else if (userValue == "3")
            //    message = "You won a new cat!";
            //else
            //{
            //    message = "Sorry, we didn't understand. ";
            //    //message = message + "You Lose.";
            //    message += "You Lose";
            //}

            //Console.WriteLine(message);

            //2. (only)if or else short code
            Console.WriteLine("Bob's Big Giveaway!");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            // short if else                       true  :  false   
            string message = (userValue == "1") ? "boat" : "strand of lint";

            Console.WriteLine("You entered: {0}, therefore you won a {1}",
                userValue, message);

            Console.ReadLine();
        }
    }
}
