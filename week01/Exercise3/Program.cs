using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("What is the magic number? "); 

int magicNumber = int.Parse(Console.ReadLine());
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 101);

int guess = -1;
while (guess != magicNumber)
{
    Console.WriteLine("What is your guess? ");
    guess = int.Parse(Console.ReadLine());
    if (magicNumber > guess)
    {
        Console.WriteLine("Highter");
    }
    else if (magicNumber < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine(" You Guessed It!");
    }
}
    }
}