
using Microsoft.AspNetCore.Mvc;
using ApiDemo.Models;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private static readonly List<Post> posts = new List<Post>
        {
            new Post
            {
                Id = 1,
                Title = "My First Blog Post",
                Content = "This is my first blog post.",
                CreatedAt = DateTime.UtcNow
            },
            new Post
            {
                Id = 2,
                Title = "Learning ASP.NET Core",
                Content = "I am learning how to build Web APIs.",
                CreatedAt = DateTime.UtcNow
            },
            new Post
            {
                Id = 3,
                Title = "Understanding JavaScript Fetch",
                Content = "JavaScript fetch allows us to get data from an API.",
                CreatedAt = DateTime.UtcNow
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetPosts()
        {
            return Ok(posts);
        }

        [HttpPost]
        public ActionResult<Post> CreatePost([FromBody] Post post)
        {
            post.Id = posts.Count == 0 ? 1 : posts.Max(p => p.Id) + 1;
            post.CreatedAt = DateTime.UtcNow;

            posts.Add(post);

            return Ok(post);
        }
    }
}
