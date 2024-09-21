using System;

class Program

{
    static void Main(string[] args)
    {
        //Console.Write("What is the Magic Number? ");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guess = -1;

        while (number != guess)
        {
            Console.Write("What's your guess? ");
            string newUserGuess = Console.ReadLine();
            int newGuess = int.Parse(newUserGuess);
            if (newGuess < number)
            {
                Console.WriteLine("Go Higher ");
            }
            else if (newGuess > number)
            {
                Console.WriteLine("Go Lower ");
            }
            else
            {
                Console.WriteLine("You Guessed it! ");
                break;
            }
        }

    }
}