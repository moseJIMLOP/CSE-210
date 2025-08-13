public class EternalGoal : Goal
{
    private int _timesRecorded;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesRecorded = 0;
    }

    public override int RecordEvent()
    {
        _timesRecorded++;
        Console.WriteLine($"Goal '{Name}' recorded! Total times recorded: {_timesRecorded}. You earned {Points} points.");
        return Points; 
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{Name} - {Description} (Points: {Points}) - Times Recorded: {_timesRecorded}");
    }
}
