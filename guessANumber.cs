Random random = new Random();
int number = random.Next(1, 101);
int guess = 0;
int tries = 0;

Console.WriteLine("Welcome to Guess A Number!");
Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

while (guess != number)
{
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }

    tries++;

    if (guess < number)
    {
        Console.WriteLine("My number is greater than your guess.");
    }
    else if (guess > number)
    {
        Console.WriteLine("My number is less than your guess.");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed my number in {0} tries.", tries);
    }
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();