public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _listOfComments;
    public string DisplayVideo()
    {
        return "Hi";
    }
    public string ReturnComments()
    {
        return "Hi";
    }
    public Video(string title, string author, int length, List<Comment> listOfComments)
    {
        _title = title;
        _author = author;
        _length = length;
        _listOfComments = listOfComments;
    }
}