using System.ComponentModel.DataAnnotations;

public class Word
{
    private bool _isHidden;
    private string _text;
    public string GetWord()
    {
        if (_isHidden == true)
        {
            return "____";
        }
        else
        {
            return _text;
        }
    }
    public bool getHidden()
    {
        return _isHidden;
    }
    public void setHidden()
    {
        _isHidden = true;
    }
    public void resetHidden()
    {
        _isHidden = false;
    }
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
}