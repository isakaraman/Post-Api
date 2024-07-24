using Microsoft.AspNetCore.Mvc;
using WebApiTutorial.Models;
using WebApiTutorial.Service;

namespace WebApiTutorial.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public IActionResult Create(Posts posts)
        {
            var response=_postService.Create(posts);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var response=_postService.GetPosts(id);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _postService.GetAll();
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            return Ok(_postService.DeletePost(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePost(int id,Posts posts)
        {
            var response=_postService.UpdatePost(id, posts);
            return Ok(response);
        }
    }
}
