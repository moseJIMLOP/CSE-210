using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Goal Tracker Menu ---");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Display goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Display total points");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    RecordGoalEvent(manager);
                    break;
                case "4":
                    manager.DisplayTotalPoints();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice (1-3): ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple Goal added.");
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal Goal added.");
                break;
            case "3":
                Console.Write("Enter number of times to complete: ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points for completing all: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                Console.WriteLine("Checklist Goal added.");
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordGoalEvent(GoalManager manager)
    {
        manager.DisplayGoals();
        Console.Write("Enter goal number to record event: ");
        if (int.TryParse(Console.ReadLine(), out int goalNum))
        {
            manager.RecordEvent(goalNum);
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
}
