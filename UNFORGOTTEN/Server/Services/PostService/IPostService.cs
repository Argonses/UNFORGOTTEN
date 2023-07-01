using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Services.PostService
{
    public interface IPostService
    {
        Task<List<Post>> GetPosts();
    }
}
