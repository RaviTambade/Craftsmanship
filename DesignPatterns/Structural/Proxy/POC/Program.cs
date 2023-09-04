// See https://aka.ms/new-console-template for more information
using Transflower.DesignPattern.Proxy;
{
    
}
        var api = new JSONPlaceholderAPI();
        var apiProxy = new JSONPlaceholderAPIProxy(api);

        // Get post 1
        var post1 = await apiProxy.GetPost(3);
        Console.WriteLine($"Post 1: {post1}");

        // Get post 1 again - should retrieve from cache
        var post1Cached = await apiProxy.GetPost(4);
        Console.WriteLine($"Post 1 (cached): {post1Cached}");
    
