using System.ComponentModel.DataAnnotations;
using System;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public void DisplayScripture()
    {
        _reference.DisplayReference();
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }
    public bool HideWords()
    {
        int hiddenCount = 0;
        foreach (Word word in _words)
        {
            if (word.GetHidden() == true)
            {
                hiddenCount++;
                if (hiddenCount == 55)
                {
                    return false;
                }
            }
        }
        int wordCount = _words.Count();
        Random rand = new Random();
        for (int i = 2; i > 0;)
        {
            int randomInt = rand.Next(wordCount);
            if (_words[randomInt].GetHidden() == true) ;
            else
            {
                _words[randomInt].SetHidden();
                i--;
            }
        }
        return true;
    }
    public Scripture(int preset)
    {
        if (preset == 1)
        {
            Reference reference = new Reference("Helaman", 3, 35);
            _reference = reference;

            List<Word> words = new List<Word>
                {
                new Word("Nevertheless"),
                new Word("they"),
                new Word("did"),
                new Word("fast"),
                new Word("and"),
                new Word("pray"),
                new Word("oft,"),
                new Word("and"),
                new Word("did"),
                new Word("wax"),
                new Word("stronger"),
                new Word("and"),
                new Word("stronger"),
                new Word("in"),
                new Word("their"),
                new Word("humility,"),
                new Word("and"),
                new Word("firmer"),
                new Word("and"),
                new Word("firmer"),
                new Word("in"),
                new Word("the"),
                new Word("faith"),
                new Word("of"),
                new Word("Christ,"),
                new Word("unto"),
                new Word("the"),
                new Word("filling"),
                new Word("their"),
                new Word("souls"),
                new Word("with"),
                new Word("joy"),
                new Word("and"),
                new Word("consolation,"),
                new Word("yea,"),
                new Word("even"),
                new Word("to"),
                new Word("the"),
                new Word("purifying"),
                new Word("and"),
                new Word("the"),
                new Word("sanctification"),
                new Word("of"),
                new Word("their"),
                new Word("hearts,"),
                new Word("which"),
                new Word("sanctification"),
                new Word("cometh"),
                new Word("because"),
                new Word("of"),
                new Word("their"),
                new Word("yielding"),
                new Word("their"),
                new Word("hearts"),
                new Word("unto"),
                new Word("God.")
                };
            _words = words;

        }
    }
}