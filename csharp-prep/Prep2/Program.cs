using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        int gradeA = 90; 
        int gradeB = 80;
        int gradeC = 70;
        int gradeD = 60;
        int gradeF = 60;

        string won = "Congratulations! you have passed!";
        string lose = "We encourage you to keep working and try again,";
        string letter = "";
        Console.WriteLine("");
        Console.WriteLine("");

        Console.Write("What was your Final Grade percentage? -Please type only the number:  ");
        string finalUserGradeInput = Console.ReadLine();
        int finalUserGradeNumber = int.Parse(finalUserGradeInput);

        if (finalUserGradeNumber >= gradeA)
        {
            letter = "A";
            Console.WriteLine($"{won} your Final Grade is {letter}!!!!!!!! ");
        }
        else if (finalUserGradeNumber >= gradeB)
        {
            letter = "B";
            Console.WriteLine($"{won} your Final Grade is {letter}! ");
        }
        else if (finalUserGradeNumber >= gradeC)
        {
            letter = "C";
            Console.WriteLine($"{won} your Final Grade is {letter}! ");
        }
        else if (finalUserGradeNumber >= gradeD)
        {
            letter = "D";
            Console.WriteLine($"{won} your Final Grade is {letter}! ");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"{lose} your Final Grade is {letter}! ");
        }
        Console.WriteLine("");
    }
}