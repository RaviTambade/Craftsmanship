using System.Text.Json;

namespace Transflower.DesignPattern.Proxy;
public class JSONPlaceholderAPIProxy : IPostAPI
{
    private readonly IPostAPI _postAPI;
    private readonly Dictionary<int, Post> _postCache;

    public JSONPlaceholderAPIProxy(IPostAPI postAPI)
    {
        _postAPI = postAPI;
        _postCache = new Dictionary<int, Post>();
    }

    public async Task<Post?> GetPost(int postId)
    {
        if (_postCache.ContainsKey(postId))
        {
            Console.WriteLine($"Retrieving post {postId} from cache.");
            return _postCache[postId];
        }

        var post = await _postAPI.GetPost(postId);
        _postCache[postId] = post;
        return post;
    }
}