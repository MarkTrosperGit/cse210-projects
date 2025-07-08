public class Eternal : Goals
{
    private int _pointsPer;
    public override void getSave()
    {

    }
    public override void recordEvent()
    {
        throw new NotImplementedException();
    }
    public Eternal(string name, string description, int score, bool isComplete, int pointsPer) : base(name, description, score, isComplete)
    {
        _pointsPer = pointsPer;
    }
}