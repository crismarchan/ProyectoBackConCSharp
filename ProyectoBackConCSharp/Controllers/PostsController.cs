using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ProyectoBackConCSharp.DTOs;
using ProyectoBackConCSharp.Services;

namespace ProyectoBackConCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostsService _titlesService;

       public PostsController(IPostsService titleService)
        {
            _titlesService = titleService;
        }

        [HttpGet]
        public async Task <IEnumerable<PostDto>> Get() =>
          await _titlesService.Get();
        

    }
}
