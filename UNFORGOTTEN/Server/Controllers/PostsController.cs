using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UNFORGOTTEN.Server.Services.PostService;
using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _service;

        public PostsController(IPostService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Post>> GetPosts()
        {
            return await _service.GetPosts();
        }
    }
}
