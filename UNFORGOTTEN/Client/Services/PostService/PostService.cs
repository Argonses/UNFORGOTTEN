using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using UNFORGOTTEN.Shared;
using static System.Net.WebRequestMethods;


namespace UNFORGOTTEN.Client.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly HttpClient _http;

        public PostService(HttpClient http)
        {
            _http = http;
        }

        public List<Post> Posts { get; set; } = new List<Post>();

        public async Task<Post> AddPost(Post post)
        {
            post.AddedOn = DateTime.Now;

            await _http.PostAsJsonAsync<Post>("api/Posts", post);
            return post;
        }

        public async Task GetPosts()
        {
            var result = await _http.GetFromJsonAsync<List<Post>>("api/Posts");
            if (result != null)
            {
                Posts = result;
            }
        }
    }
}
