using System;

class Word
{

// Attributes
private string _word;
private bool _isHidden;

// Constructor(s)
public Word(string word)
{
    _word = word;
}

// Methods
public bool GetIsHidden()
{
    return _isHidden;
}
public bool SetIsHidden(bool isHidden)
{
    _isHidden = isHidden;
    return _isHidden;
}
public string GetWord()
{
    return _word;
}

}