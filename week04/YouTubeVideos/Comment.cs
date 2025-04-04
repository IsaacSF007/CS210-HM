using System;

class Comment
{
    private string _commenter;
    private string _comment;

    public Comment(string commenter, string comment)
    {
        this._commenter = commenter;
        this._comment = comment;
    }

    public string GetComment()
    {
        return _comment;
    }

    public string GetCommenter()
    {
        return _commenter;
    }
}
