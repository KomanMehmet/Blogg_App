using HoppyWiseBlog.Entity;

namespace HoppyWiseBlog.Data.Abstract
{
    public interface IPostRepository
    {
        //extra filtreleme ekleyebileceğiz.
        IQueryable<Post> Posts{ get; }

        void CreatePost(Post post);

        void EditPost(Post post);

        void EditPost(Post post, int[] tagIds);

    }
}