using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        while (true)
        {
            Console.Write("Enter your guess: ");
            if (!int.TryParse(Console.ReadLine(), out int guess) || guess < 1 || guess > 100)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 100.");
                continue;
            }

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try a higher number.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try a lower number.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the secret number {secretNumber} correctly!");
                break;
            }
        }
    }
}
