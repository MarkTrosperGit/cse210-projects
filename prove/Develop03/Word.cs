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
    public bool GetHidden()
    {
        return _isHidden;
    }
    public void SetHidden()
    {
        _isHidden = true;
    }
    public void ResetHidden()
    {
        _isHidden = false;
    }
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
}