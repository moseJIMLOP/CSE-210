using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[goalIndex - 1];
        int pointsEarned = goal.RecordEvent();

        if (pointsEarned > 0)
        {
            _totalPoints += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("No points earned for this event.");
        }

        Console.WriteLine($"Total points: {_totalPoints}");
    }

    public void DisplayTotalPoints()
    {
        Console.WriteLine($"Total points: {_totalPoints}");
    }
}
