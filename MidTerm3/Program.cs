using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User input guess
            Console.WriteLine("Guess a number between 1 and 100!");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != 37)
            {
                //checks for higher or lower amount, then re-prompts guess
                if (guess < 37)
                {
                    Console.WriteLine("Too low!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    
                }
                else if (guess > 37)
                {
                    Console.WriteLine("Too high!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    
                }
                //really simple guessing code!
            }
            Console.WriteLine("Correct!");
            Console.ReadLine();
        }
    }
}
