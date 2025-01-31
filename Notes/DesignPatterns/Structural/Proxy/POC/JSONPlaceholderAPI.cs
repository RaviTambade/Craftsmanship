using System.Text.Json;

namespace Transflower.DesignPattern.Proxy;

public class JSONPlaceholderAPI : IPostAPI
{
    private readonly HttpClient _httpClient;

    public JSONPlaceholderAPI()
    {
        _httpClient = new HttpClient();
    }

    public async Task<Post?> GetPost(int postId)
    {
        var response = await _httpClient.GetAsync($"https://jsonplaceholder.typicode.com/posts/{postId}");

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Failed to retrieve post {postId} from API: {response.ReasonPhrase}");
        }

        var json = await response.Content.ReadAsStringAsync();

       var options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        var post = JsonSerializer.Deserialize<Post?>(json,options);
        return post;
    }
}