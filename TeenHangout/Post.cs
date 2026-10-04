namespace TeenHangout;

public class Post // using the post class, this would provide us with
// the Username, Content of the web app, and the like of set post. 
{
    public string Username { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }

    public Post(string username, string content, int likes)
    {
        Username = username;
        Content = content;
        Likes = likes;

    }
}