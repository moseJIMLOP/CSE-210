using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
            static void DisplayWelcomeMessage()
            {
                Console.WriteLine("Welcome to the program!");
            }
            static void PromptUserName(string userName)
            {
                Console.WriteLine($"Please enter your name: {userName}");
            }
            static int PromptUserNumber(int favoriteNumber)
            {
                Console.WriteLine($"Please enter your favorite number: 42");
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
}