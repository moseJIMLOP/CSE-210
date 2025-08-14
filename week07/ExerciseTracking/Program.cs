using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Activity running = new Running("03 Nov 2022", 30, 4.8);
        Activity cycling = new Cycling("03 Nov 2022", 45, 20.0);
        Activity swimming = new Swimming("03 Nov 2022", 25, 40);

        List<Activity> activities = new List<Activity>() { running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
    