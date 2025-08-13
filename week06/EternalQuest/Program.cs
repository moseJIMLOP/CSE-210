using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();

        manager.AddGoal(new SimpleGoal("Read book", "Read 50 pages", 10));
        manager.AddGoal(new EternalGoal("Exercise", "Daily workout", 5));
        manager.AddGoal(new ChecklistGoal("Gym", "Go to the gym", 2, 5, 10));

        manager.DisplayGoals();

        manager.RecordEvent(1);
        manager.RecordEvent(2);
        manager.RecordEvent(3);

        manager.DisplayGoals();
    }
}
