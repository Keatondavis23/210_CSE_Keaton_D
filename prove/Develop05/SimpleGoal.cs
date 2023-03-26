namespace Develop05;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Completed goal: {Name} (+{Points} points)");
    }

    public override string GetStatus()
    {
        return "[ ] " + Name;
    }
}
