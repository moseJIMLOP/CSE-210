using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine(" What is your fist name? ");
string name = Console.ReadLine();

Console.WriteLine("What is your last name? ");
string lastname = Console.ReadLine();

Console.WriteLine($"Your Name is {lastname}, {name} {lastname}."); 
    }
}