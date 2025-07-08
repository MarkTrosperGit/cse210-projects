using System.ComponentModel;

public abstract class Goals
{
    private string _name;
    private string _description;
    private int _score;
    private bool _isComplete;
    public int getScore()
    {
        return 0;
    }
    public abstract void getSave();
    public abstract void recordEvent();
    protected Goals(string name, string description, int score, bool isComplete)
    {
        _name = name;
        _description = description;
        _score = score;
        _isComplete = isComplete;

    }
}