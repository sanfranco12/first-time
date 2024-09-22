using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Type a Number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        List<int> numbers = new List<int>();
        numbers.Add(number);

        while (number != 0)
        {
            Console.Write("Type a Number: ");
            string newNumber = Console.ReadLine();
            int now = int.Parse(newNumber);
            numbers.Add(now);
            if (now == 0)
            {
                break;
            }
            
        }
        int summary = numbers.Sum();
        int largest = numbers.Max();
        double average = numbers.Average();
        Console.WriteLine("The Sum is: " + summary);
        Console.WriteLine("The largest number is: " + largest);   
        Console.WriteLine("The average is: " + average);

    }
}