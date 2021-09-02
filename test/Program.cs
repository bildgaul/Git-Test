using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 0;
            int min, max;
            Console.WriteLine("Input the minimum value the guess can be.");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the maximum value the guess can be.");
            max = Convert.ToInt32(Console.ReadLine());
            int quit = min - 1;
            int input;
            var rand = new Random();
            int randNum = rand.Next(min, max + 1);
            do
            {
                Console.WriteLine("Guess a number between " + min + " and " + max + ". Enter " + quit + " to quit.");
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 0 || input > 100)
                {
                    Console.WriteLine("Number out of bounds! Please enter a number between " + min + " and " + max + ".");
                }
                else if (input >= min && input < randNum)
                {
                    Console.WriteLine("Your guess was too low! Try again.");
                    tries++;
                }
                else if (input <= max && input > randNum)
                {
                    Console.WriteLine("Your guess was too high! Try again.");
                    tries++;
                }
            } while (input != quit && input != randNum);
            Console.WriteLine("The number was: " + randNum);
            Console.WriteLine("Number of tries: " + tries);
        }
    }
}
