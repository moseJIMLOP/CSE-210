using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program ✨😊!");
            Console.WriteLine("Please select one the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            string input = Console.ReadLine();
            bool success = int.TryParse(input, out choice); 
            
            if (!success)
            {
                Console.WriteLine("Please enter a number.");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);

            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Please enter the file name to load:");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the file name to save it 🤠:");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Good job today!");
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }
}