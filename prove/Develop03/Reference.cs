using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;  //Add to cm file
    public void DisplayReference()
    {
        if (!_endVerse.HasValue) //Add to cm file
        {
            Console.WriteLine($"{_book} {_chapter}: {_startVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_startVerse}-{_endVerse}");
        }
    }
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;  //Add to cm file
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
}