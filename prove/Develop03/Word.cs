using System;

class Word
{
    public Word(string text, bool isHidden)
    {
        Text = text;
        IsHidden = isHidden;
    }
    public string Text { get; set; }
    public bool IsHidden { get; set; }
    public override string ToString()
    {
        if (IsHidden)
        {
            return new string ('_',Text.Length);
        }
        else 
        {
            return Text;
        }
    }
}