using WebApiTutorial.Models;

namespace WebApiTutorial.Service
{
    public interface IPostService
    {
        Posts Create(Posts post);
        Posts UpdatePost(int id,Posts post);
        Posts GetPosts(int id);
        List<Posts> GetAll();
        Posts DeletePost(int id);


    }

}
