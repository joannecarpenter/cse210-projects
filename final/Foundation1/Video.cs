using System;

class Video
{
    // Attributes
    private string _title = "", _author = "";
    private int _length = 0, _commentsAmount = 0;
    private List<string> _comments = new List<string>();
    private List<string> _videos = new List<string>();
    
    // Constructors
    public Video()
    {}

    // Methods
    public int CountComments()
    {
       _commentsAmount = _comments.Count();
       return _commentsAmount;
    }

    public string DisplayVideoDetails()
    {
        return $"Title: {_title}, Author: {_author}, Length in seconds: {_length}, Number of comments: {_commentsAmount}";
    }

    public void AddToVideoList()
    {
        _videos.Add(DisplayVideoDetails());
    }
    
    public void AddToCommentsList()
    {
        var comment = new Comment();
        string name = comment.GetCommentorName();
        string text = comment.GetCommentorText();
        _comments.Add(comment.DisplayCommentInfo());
    }
    public string GetTitle()
    {
        Console.Write("What is the video's title? ");
        string title = Console.ReadLine();
        _title = title;
        return _title;
    }
    public string GetAuthor()
    {
        Console.Write("Who is the author of the video? ");
        string author = Console.ReadLine();
        _author = author;
        return _author;
    }
    public int GetLength()
    {
        Console.Write("What is the length of the video in seconds? ");
        string length = Console.ReadLine();
        _length = Int32.Parse(length);
        return _length;
    }

    public void DisplayDetailsAndComments()
    {
        foreach (string video in _videos){
            Console.WriteLine(video);
        }
        foreach (string comment in _comments){
            Console.WriteLine(comment);
        }
    }
}