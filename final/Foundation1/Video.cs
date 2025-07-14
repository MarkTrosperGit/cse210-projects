public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _listOfComments;
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title} by {_author}, {_length} minutes:");
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _listOfComments)
        {
            Console.WriteLine($"{comment.GetPerson()}: {comment.GetText()}");
        }
    }
    public Video(string title, string author, int length, List<Comment> listOfComments)
    {
        _title = title;
        _author = author;
        _length = length;
        _listOfComments = listOfComments;
    }
}