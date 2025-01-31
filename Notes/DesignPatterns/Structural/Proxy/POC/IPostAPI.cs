using System.Text.Json;

namespace Transflower.DesignPattern.Proxy;

public interface IPostAPI
{
    Task<Post?> GetPost(int postId);
}