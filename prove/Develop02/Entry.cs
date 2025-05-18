public class Entry
{
    public string _answer { get; set; }
    public string _question { get; set; }
    public string _date = DateTime.Now.ToShortDateString();

    public Entry(string answer, string question)
    {
        _answer = answer;
        _question = question;
    }

    public string getEntry()
    {
        return $"({_date}) {_question}: \n{_answer}\n";
    }
}