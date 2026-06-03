using ProyectoBackConCSharp.DTOs;

namespace ProyectoBackConCSharp.Services
{
    public interface IPostsService
    {
        public Task<IEnumerable<PostDto>> Get();
    }
}
