using System;

class FishingTale
{
    static void Main()
    {
        Console.WriteLine("Welcome to my Fishing Game!");

        int playerScore = 0;
        int wormsRemaining = 5;
        Random random = new Random();

        while (wormsRemaining > 0)
        {
            Console.WriteLine($"\nWorms remaining: {wormsRemaining}");
            Console.WriteLine("1. Cast your fishing rod");
            Console.WriteLine("2. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int fishCaught = Fish();
                playerScore += fishCaught;
                wormsRemaining--;

                Console.WriteLine($"You caught {fishCaught} fish!");
                Console.WriteLine($"Your total score is: {playerScore}");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thanks for playing! Your final score is: " + playerScore);
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }
        }

        Console.WriteLine("Game over! You ran out of worms.");
    }

    static int Fish()
    {
        Random random = new Random();
        int fishSize = random.Next(1, 10);

        Console.WriteLine($"You cast your fishing rod and wait...");

   
        Thread.Sleep(2000);

        if (fishSize < 5)
        {
            Console.WriteLine("You caught a small fish!");
            return 1;
        }
        else if (fishSize < 8)
        {
            Console.WriteLine("You caught a medium-sized fish!");
            return 2;
        }
        else
        {
            Console.WriteLine("You caught a big fish!");
            return 3;
        }
    }
}


