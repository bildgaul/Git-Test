using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        const int QUIT = 0;
        static void Main(string[] args)
        {
            int tries = 0;
            int input;
            var rand = new Random();
            int randNum = rand.Next(1, 101);
            do
            {
                Console.WriteLine("Guess a number between 1 and 100. Enter " + QUIT + " to quit.");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input);
                if (input < 0 || input > 100)
                {
                    Console.WriteLine("Number out of bounds! Please enter a number between 1 and 100.");
                }
                else if (input > 0 && input < randNum)
                {
                    Console.WriteLine("Your guess was too low! Try again.");
                    tries++;
                }
                else if (input < 100 && input > randNum)
                {
                    Console.WriteLine("Your guess was too high! Try again.");
                    tries++;
                }
            } while (input != QUIT && input != randNum);
            Console.WriteLine("The number was: " + randNum);
            Console.WriteLine("Number of tries: " + tries);
        }
    }
}
