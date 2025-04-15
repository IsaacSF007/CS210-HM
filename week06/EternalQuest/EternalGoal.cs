public class EternalGoal : Goal
{
    public EternalGoal(string name, string description) : base(name, description) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for '{_name}'. This goal can be recorded indefinitely.");
    }

    public override string GetGoalDetails()
    {
        return $"{_name}: {_description} - Completed: {_isCompleted}. This goal is eternal.";
    }
}
