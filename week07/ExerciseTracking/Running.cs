using System;

public class Running : Activity
{
    private double _distance; 
    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        
        return _distance / (GetLength() / 60.0);
    }

    public override double GetPace()
    {
       
        return GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min) - Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }
}
