using HoppyWiseBlog.Entity;

namespace HoppyWiseBlog.Data.Abstract
{
    public interface ICommentRepository
    {
        //extra filtreleme ekleyebileceğiz.
        IQueryable<Comment> Comments{ get; }

        void CreateComment(Comment comment);

    }
}