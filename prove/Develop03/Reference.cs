using System;

class Reference
{
    // Attributes
    private string _verseStart; 
    private string _verseEnd; 
    private string _chapter; 
    private string _book; 

    // Constructor(s)
    // For one verse
    public Reference(string chapter, string book, string verseStart)
    {
        _chapter = chapter;
        _book = book;
        _verseStart = verseStart;
        _verseEnd = "";
    }
    // For multiple verses
    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        _chapter = chapter;
        _book = book;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    // Methods
    public string GetReference()
    {
        // If this is a single verse scripture, _verseEnd == ""
        // So if it is a single verse scripture,
        // print the verse in this format.
        if (_verseEnd == "")
        {
            return($"{_book} {_chapter}:{_verseStart}");
        }
        // Otherwise it would be a multiple verse and _verseEnd would not be blank
        // So if it is a multiple verse scripture,
        // print the verse in this format.
        else
        {
            return($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
    }
}