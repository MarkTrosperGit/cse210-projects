public class Simple : Goals
{
    private int _points;
    public override void getSave()
    {

    }
    public override void recordEvent()
    {
        throw new NotImplementedException();
    }
    public Simple(string name, string description, int score, bool isComplete, int points) : base(name, description, score, isComplete)
    {
        _points = points;
    }


}