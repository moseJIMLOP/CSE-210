using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int UserNumber = -1;
        while (UserNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string UserResponse = Console.ReadLine();
            UserNumber = int.Parse(UserResponse);

            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number; 
            }
            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                Console.WriteLine($"The largest number is: {max}");

            }


        }

        
    }
}