public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public List<Post> Posts { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}

using (var db = new BloggingContext())
{
    var blog = new Blog { Url = "http://blogs.msdn.com/adonet" };
    db.Blogs.Add(blog);
    db.SaveChanges();
}
