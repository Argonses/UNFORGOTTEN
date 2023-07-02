using Microsoft.EntityFrameworkCore;
using UNFORGOTTEN.Server.Data;
using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Post> AddPost(Post post)
        {
            await _context.AddAsync(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<List<Post>> GetPosts()
        {
            var result = await _context.Posts.ToListAsync();
            return result;
        }
    }
}
