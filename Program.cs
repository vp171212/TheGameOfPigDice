using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfPigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~Welcome to the Game of Pig~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~To win You have to score 20 or More~~~~~~~~~~~");
            Console.WriteLine("To roll Press:r,To hold Press:h");
            int score = 0;
            int output;
            int turnScore;
            while (score < 20)
            {
                output = 0;
                turnScore = 0;
                Console.WriteLine("Please roll");
                string command = Console.ReadLine();
                while (command == "r")
                {
                    if (command == "r")
                    {
                        Random rnd = new Random();
                        output = rnd.Next(1, 7);
                    }
                    Console.WriteLine(output);
                    if (output == 1)
                    {
                        turnScore = 0;
                        command = "h";
                        break;
                    }
                    else
                        turnScore += output;
                    Console.WriteLine("To roll Press:r,To hold Press:h");
                    command = Console.ReadLine();
                }
                score += turnScore;
                Console.WriteLine("Your Turn Score: " + turnScore);
                Console.WriteLine("Your Total Score: " + score);

            }
            Console.WriteLine("***************Congratulations You Win****************");
        }
    }
}
