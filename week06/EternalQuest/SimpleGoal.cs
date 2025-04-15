public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description) : base(name, description) { }

    public override void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"Simple Goal '{_name}' marked as completed.");
    }

    public override string GetGoalDetails()
    {
        return $"{_name}: {_description} - Completed: {_isCompleted}";
    }
}
