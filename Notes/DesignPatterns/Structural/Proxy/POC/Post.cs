using System.Text.Json;

namespace Transflower.DesignPattern.Proxy;

public class Post
{
    public int UserId
    {
        get; set;
    }
    public int Id
    {
        get; set;
    }
    public string? Title
    {
        get; set;
    }
    public string? Body
    {
        get; set;
    }

    public override string ToString() => $"<{Id}> - {Title}";
}