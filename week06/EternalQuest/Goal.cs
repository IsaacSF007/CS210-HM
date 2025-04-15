public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected bool _isCompleted;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _isCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetGoalDetails();

    public bool IsCompleted()
    {
        return _isCompleted;
    }
}
