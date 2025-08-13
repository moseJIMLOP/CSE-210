public class ChecklistGoal : Goal
{
    private int _timesCompleted;     
    private int _targetCount;        
    private int _bonusPoints;        

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            Console.WriteLine($"Progress for '{Name}': {_timesCompleted}/{_targetCount}.");

            if (_timesCompleted == _targetCount)
            {
                Console.WriteLine($"Checklist goal '{Name}' completed! You earned {Points + _bonusPoints} points.");
                return Points + _bonusPoints;
            }
            else
            {
                Console.WriteLine($"You earned {Points} points.");
                return Points;
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
            return 0;
        }
    }

    public override void DisplayGoal()
    {
        string status = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} (Points: {Points}, Bonus: {_bonusPoints}, Progress: {_timesCompleted}/{_targetCount})");
    }
}
