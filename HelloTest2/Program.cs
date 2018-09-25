using System;

namespace HelloTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int answer = random.Next(1, 50);
            int guesses = 0;
            Console.WriteLine("Try guessing my number.");

            bool playing = true;

            while (playing) {

            var guess = Console.ReadLine();
            guesses++;

            int.TryParse(guess, out int x );

            if (x == answer)
            {

                Console.WriteLine("great guess");
                playing = false;
                break;
            }

                    
            if (x > answer)
            {
               Console.WriteLine("Guess Lower");
               continue;
                    
            }
            if (x < answer)
            {
             Console.WriteLine("Guess Higher");
             continue;

            }
            }

            Console.WriteLine("You Guessed it!");
            Console.ReadLine();
        }
    }
}
