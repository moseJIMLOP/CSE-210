public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string Name => _name;
    public string Description => _description;
    public int Points => _points;
    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_name} - {_description} (Points: {_points})");
    }
    public int GetPoints()
    {
        return _points;
    }

}