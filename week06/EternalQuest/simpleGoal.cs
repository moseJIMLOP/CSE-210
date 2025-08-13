public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
            return Points;
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
            return 0;
        }
    }

    public override void DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} (Points: {Points})");
    }
}

