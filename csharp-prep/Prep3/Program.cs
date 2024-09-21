using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? ");
        string magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);

        Console.Write("What's your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        if (guess < number)
        {
            Console.WriteLine("Go Higher ");
        }
        else if (guess > number)
        {
            Console.WriteLine("Go Lower ");
        }
        else
        {
            Console.WriteLine("You Guessed it! ");
        }
    }
}