public class Comment
{
    private string _person;
    private string _text;
    public string GetPerson()
    {
        return _person;
    }
    public string GetText()
    {
        return _text;
    }
    public Comment(string person, string text)
    {
        _person = person;
        _text = text;
    }
}