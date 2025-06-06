using System.ComponentModel;

public class Word
{
    private string _text;
    public bool _isHidden;
    public Word (string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            _text = text;
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

}