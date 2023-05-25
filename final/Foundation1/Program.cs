using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video();
        video1.GetTitle();
        video1.GetAuthor();
        video1.GetLength();
        video1.AddToCommentsList();
        video1.AddToCommentsList();
        video1.AddToCommentsList();
        video1.CountComments();
        video1.AddToVideoList();

        var video2 = new Video();
        video2.GetTitle();
        video2.GetAuthor();
        video2.GetLength();
        video2.AddToCommentsList();
        video2.AddToCommentsList();
        video2.AddToCommentsList();
        video2.CountComments();
        video2.AddToVideoList();

        var video3 = new Video();
        video3.GetTitle();
        video3.GetAuthor();
        video3.GetLength();
        video3.AddToCommentsList();
        video3.AddToCommentsList();
        video3.AddToCommentsList();
        video3.AddToCommentsList();
        video3.CountComments();
        video3.AddToVideoList();

        var video4 = new Video();
        video4.GetTitle();
        video4.GetAuthor();
        video4.GetLength();
        video4.AddToCommentsList();
        video4.AddToCommentsList();
        video4.AddToCommentsList();
        video4.CountComments();
        video4.AddToVideoList();

        Console.WriteLine();
        Console.WriteLine("Here are your video 1 details:");
        video1.DisplayDetailsAndComments();
        Console.WriteLine();
        Console.WriteLine("Here are your video 2 details:");
        video2.DisplayDetailsAndComments();
        Console.WriteLine();
        Console.WriteLine("Here are your video 3 details:");
        video3.DisplayDetailsAndComments();
        Console.WriteLine();
        Console.WriteLine("Here are your video 4 details:");
        video4.DisplayDetailsAndComments();
    }
}