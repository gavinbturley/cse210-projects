public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetDisplayText();
        _words = text.Split(' ').Select(word=> new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = 0;
        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        int numberOfWords = _words.Count;
        int numberOfHiddenWords = 0;
        foreach (Word word in _words)
        {   
            if (word.IsHidden())
            { 
                numberOfHiddenWords++; 
            }
        }
        if (numberOfWords == numberOfHiddenWords){return true;}
        else {return false;}
    }   
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
        }
}
