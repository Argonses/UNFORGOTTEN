using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Client.Services.PostService
{
    public interface IPostService
    {
        List<Post> Posts { get; set; }
        Task GetPosts();
        Task<Post> AddPost(Post post);
    }
}
