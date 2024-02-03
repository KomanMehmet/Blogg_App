using HoppyWiseBlog.Entity;
using Microsoft.EntityFrameworkCore;

namespace HoppyWiseBlog.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if(!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag {Text = "Web Programlama", Url = "web-programlama", Color = TagColors.warning},
                        new Tag {Text = "Backend", Url = "backend", Color = TagColors.danger},
                        new Tag {Text = "Frontend", Url = "frontend", Color = TagColors.success},
                        new Tag {Text = "Fullstack", Url = "fullstack", Color = TagColors.secondary},
                        new Tag {Text = "php", Url = "php", Color = TagColors.primary}
                    );

                    context.SaveChanges();
                }

                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User {UserName = "Ayşegül Koman", Name = "Ayşegül Koman", Email = "aysegul@gmail.com", Password = "123456", Image = "p1.jpg"},
                        new User {UserName = "Selma Doğan", Name = "Selma Doğan", Email = "selma@gmail.com", Password = "123456", Image = "p2.jpg"}

                    );

                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post 
                        {Title = "Asp.net core", 
                        Description = "Asp.net core dersleri",
                        Content = "Asp.net core dersleri", 
                        Url = "aspnet-core",
                        IsActive = true, 
                        PublishedOn = DateTime.Now.AddDays(-10), 
                        Tags = context.Tags.Take(3).ToList(),
                        Image = "1.jpg",
                        UserId = 1,
                        Comments = new List<Comment> {new Comment { CommentText ="İyi bir kurs", PublishedOn = DateTime.Now.AddDays(-20), UserId = 1},
                                                    new Comment { CommentText ="Çok faydalandığım bir kurs", PublishedOn = DateTime.Now.AddDays(-10), UserId = 2}}
                        },
                        new Post 
                        {Title = "Php", 
                        Description = "Php core dersleri",
                        Content = "Php core dersleri", 
                        Url = "php-core",
                        IsActive = true, 
                        PublishedOn = DateTime.Now.AddDays(-20), 
                        Tags = context.Tags.Take(2).ToList(),
                        Image = "2.jpg",
                        UserId = 1,
                        },
                        new Post 
                        {Title = "Django", 
                        Description = "Django dersleri",
                        Content = "Django dersleri", 
                        Url = "django",
                        IsActive = true, 
                        PublishedOn = DateTime.Now.AddDays(-50), 
                        Tags = context.Tags.Take(4).ToList(),
                        Image = "3.jpg",
                        UserId = 2,
                        },
                        new Post 
                        {Title = "React", 
                        Description = "React dersleri",
                        Content = "React dersleri", 
                        Url = "react",
                        IsActive = true, 
                        PublishedOn = DateTime.Now.AddDays(-30), 
                        Tags = context.Tags.Take(4).ToList(),
                        Image = "3.jpg",
                        UserId = 2,
                        },
                        new Post 
                        {Title = "Angular", 
                        Description = "Angular dersleri",
                        Content = "Angular dersleri", 
                        Url = "angular",
                        IsActive = true, 
                        PublishedOn = DateTime.Now.AddDays(-40), 
                        Tags = context.Tags.Take(4).ToList(),
                        Image = "3.jpg",
                        UserId = 2,
                        },
                        new Post 
                        {Title = "Web Tasarım", 
                        Description = "Web tasarım dersleri",
                        Content = "Web Tasarım dersleri", 
                        Url = "web-tasarım",
                        IsActive = true, 
                        PublishedOn = DateTime.Now.AddDays(-600), 
                        Tags = context.Tags.Take(4).ToList(),
                        Image = "3.jpg",
                        UserId = 2,
                        }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}