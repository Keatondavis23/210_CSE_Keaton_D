namespace Develop05;

public class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine($"Recorded progress on goal: {Name} (+{Points} points)");
    }

    public override string GetStatus()
    {
        return $"{_count}x {Name}";
    }
}