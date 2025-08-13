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
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

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
                    manager.SaveGoals();
                    break;
                case "4":
                    manager.LoadGoals();
                    break;
                case "5":
                    RecordGoalEvent(manager);
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("Enter a description for this goal: ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal: ");
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
