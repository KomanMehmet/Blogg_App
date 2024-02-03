using HoppyWiseBlog.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HoppyWiseBlog.ViewComponents
{
    public class NewPosts : ViewComponent
    {

        private IPostRepository _postRepository;

        public NewPosts(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _postRepository
                .Posts
                .OrderByDescending(post => post.PublishedOn)
                .Take(5)
                .ToListAsync()
            );
        }
    }
}