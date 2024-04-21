using System;

namespace AY_Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RAND = random.Next(0, 2);
            int score = 0; //for tracking score 

            Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
            Console.WriteLine("Name??");
            string NAME = Console.ReadLine();

            Console.WriteLine("Welcome, " + NAME + "! Do you accept this challenge? Yes/No");
            string INPUT = Console.ReadLine();

            if (INPUT == "Yes")
            {
                Console.WriteLine("YAY! Lets play"); 
            }
            if (INPUT == "No")
            {
                Console.WriteLine("You're a coward, " + NAME);
                Environment.Exit(0);
            }
            int repeat = 5;
            for (int i = 0; i < repeat; i++)
            {
            Console.Write("What is your guess? H (head) or T (tails)?");
            string guess = Console.ReadLine();

            if (RAND == 0 && guess == "H")
            {
                Console.WriteLine("The coin flip was Heads, you win!");
                    ++score;
                    Console.WriteLine("Your score is " + score);
            }
            else if (RAND == 1 && guess == "T")
            {
                Console.WriteLine("The coin flip was Tails, you win!");
                    ++score;
                    Console.WriteLine("Your score is " + score);
                }
            else
            {
                string result;

                if (RAND == 1)
                {
                    result = "H";
                }
                else
                {
                    result = "T";
                }
                Console.WriteLine("You lose this round! Coin flip was {0}", result);
                    Console.WriteLine("Your score is " + score);
                }
            }
        }
    }
}
