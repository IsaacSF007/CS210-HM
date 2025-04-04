using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        this._comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void VideoInfo ()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine($"{_length} seconds");
        Console.WriteLine($"Comments: {_comments.Count}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommenter()}: {comment.GetComment()}");
        }

    }
}