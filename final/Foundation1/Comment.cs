using System;

class Comment
{
    // Attributes
    private string _commentorName = "";
    private string _commentorText = "";

    // Constructors
    public Comment()
    {}

    // Methods 
    public string DisplayCommentInfo()
    {
       return $"Commentor: {_commentorName}, Comment: {_commentorText}";
    }
    public string GetCommentorName()
    {
        Console.Write("What is the commentor's name? ");
        string commentorName = Console.ReadLine();
        _commentorName = commentorName;
        return _commentorName;
    }
    public string GetCommentorText()
    {
        Console.Write("What is the comment? ");
        string commentorText = Console.ReadLine();
        _commentorText = commentorText;
        return _commentorText;
    }
}