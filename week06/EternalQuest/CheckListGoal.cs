public class ChecklistGoal : Goal
{
    private int _targetEvents;
    private int _eventsRecorded;

    public ChecklistGoal(string name, string description, int targetEvents) : base(name, description)
    {
        _targetEvents = targetEvents;
        _eventsRecorded = 0;
    }

    public override void RecordEvent()
    {
        if (_eventsRecorded < _targetEvents)
        {
            _eventsRecorded++;
            Console.WriteLine($"Event recorded for '{_name}'. {_eventsRecorded}/{_targetEvents} completed.");
        }
        else
        {
            _isCompleted = true;
            Console.WriteLine($"Checklist Goal '{_name}' is now completed!");
        }
    }

    public override string GetGoalDetails()
    {
        return $"{_name}: {_description} - Completed: {_isCompleted}, { _eventsRecorded}/{_targetEvents} events recorded.";
    }
}
