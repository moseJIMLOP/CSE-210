using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, userNumber, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int favoriteNumber = int.Parse(input);
        return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string UserName, int number, int squaredNumber)
    {
        Console.WriteLine($"{UserName}, the square of your number is {squaredNumber}");
    }
}