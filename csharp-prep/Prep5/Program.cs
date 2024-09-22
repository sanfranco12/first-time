using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayWelcomeMessage ()
    {
        Console.WriteLine("Welcome to the program!! ");
    }

    static string PromptUserName ()
    {
        Console.Write ("Please enter your name: ");
        string userName = Console.ReadLine ();
        return userName;
    }
    
    static int PromptUserNumber ()
    {
        Console.Write ("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse (userNumber);
        return number;
    }

    static int SquareNumber (int number)
    { 
        int userSquareNumber = number * number;
        return userSquareNumber; 
    }

    static void DisplayResult (string PromptUserName, int SquareNumber)
    {
        Console.WriteLine(PromptUserName + ", the square of your number is: " + SquareNumber);
    }


}   