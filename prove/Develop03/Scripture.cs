using System;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide=3)
    {
        Random random = new Random();
        int hiddenWords = 0;
        while (hiddenWords < numberToHide)
        {
            int index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenWords++;
                if (IsCompletelyHidden() == true)
                {
                    break;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = string.Join(" ", _words);
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
