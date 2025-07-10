using System.ComponentModel;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;
    public abstract string GetSave();
    public abstract void DisplayForList();
    public abstract int RecordEvent();
    protected void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public string GetName()
    {
        return _name;
    }
    protected string GetDescription()
    {
        return _description;
    }
    protected int GetPoints()
    {
        return _points;
    }
    protected bool GetIsComplete()
    {
        return _isComplete;
    }
    protected Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;

    }
}