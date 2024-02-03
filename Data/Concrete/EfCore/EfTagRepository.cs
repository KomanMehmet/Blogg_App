using HoppyWiseBlog.Data.Abstract;
using HoppyWiseBlog.Data.Concrete.EfCore;
using HoppyWiseBlog.Entity;

namespace HoppyWiseBlog.Data.Concrete
{
    public class EfTagRepository : ITagRepository
    {

        private BlogContext _context;

        public EfTagRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Tag> Tags => _context.Tags;

        public void CreateTag(Tag Tag)
        {
            _context.Tags.Add(Tag);
            _context.SaveChanges();
        }
    }
}