using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage? ");
string valueFromUser = Console.ReadLine();

int percent = int.Parse(valueFromUser);

if (percent >= 90)
{
    Console.WriteLine("A");
}
else if (percent >= 80)
{
    Console.WriteLine("B");
}
else if (percent >= 70)
{
    Console.WriteLine("C");
}
else if (percent >= 60)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}

Console.WriteLine($"You got a: {percent}.");

if (percent >= 70)
{
    Console.WriteLine("Congratulations! You did it!");
}
else
{
    Console.WriteLine("Good Luck Next Time!");
}
    }
}