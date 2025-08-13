using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted < _targetCount)
        {
            Console.WriteLine($"Progress: {_timesCompleted}/{_targetCount}. You earned {Points} points.");
            return Points;
        }
        else if (_timesCompleted == _targetCount)
        {
            Console.WriteLine($"Goal completed! You earned {Points + _bonusPoints} points (including bonus).");
            return Points + _bonusPoints;
        }
        else
        {
            Console.WriteLine($"Goal already completed. No extra points.");
            return 0;
        }
    }

    public override void DisplayGoal()
    {
        string status = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} (Points: {Points}) - Completed {_timesCompleted}/{_targetCount} times");
    }
}
