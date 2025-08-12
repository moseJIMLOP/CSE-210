public class SimpleGoal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }
    public override void DisplayGoal()
    {
        string status = _isComplete ? "[x]" : "[ ]";
        Console.WriteLine($"{status}");
        base.DisplayGoal();
    }
}