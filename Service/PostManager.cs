using WebApiTutorial.Models;
using WebApiTutorial.Repository;

namespace WebApiTutorial.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;

        public PostManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;
        }
        public Posts Create(Posts post)
        {
            return _repository.Add(post);
        }

        public Posts DeletePost(int id)
        {
            var deletePost = _repository.GetById(id);
            return _repository.Delete(deletePost);
        }

        public List<Posts> GetAll()
        {
            return _repository.GetAll();
        }

        public Posts GetPosts(int id)
        {
            return _repository.GetById(id);
        }

        public Posts UpdatePost(int id, Posts post)
        {
            return _repository.UpdateById(id, post);
        }
    }
}
