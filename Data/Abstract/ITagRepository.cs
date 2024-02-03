using HoppyWiseBlog.Entity;

namespace HoppyWiseBlog.Data.Abstract
{
    public interface ITagRepository
    {
        //extra filtreleme ekleyebileceğiz.
        IQueryable<Tag> Tags{ get; }

        void CreateTag(Tag tag);

    }
}