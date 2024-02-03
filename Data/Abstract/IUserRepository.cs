using HoppyWiseBlog.Entity;

namespace HoppyWiseBlog.Data.Abstract
{
    public interface IUserRepository
    {
        //extra filtreleme ekleyebileceğiz.
        IQueryable<User> Users{ get; }

        void CreateUser(User user);
    }
}