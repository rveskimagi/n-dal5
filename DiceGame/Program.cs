using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAttempts = 3;

            Random rnd = new Random();

            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;

            Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

            if (cpuRandom < userRandom)
            {
                Console.WriteLine("Kasutaja on mängu võtnud. Palju õnne!");
                userScore = userScore + 1;

            }
            else if(cpuRandom > userRandom)
            {
                Console.WriteLine("Arvuti on mängu võitnud");
                cpuScore = cpuScore + 1;

            }
            else
            {
                Console.WriteLine("Viik!");
            }
        }
    }
}
