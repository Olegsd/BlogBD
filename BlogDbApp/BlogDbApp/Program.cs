using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BlogDbContext();
            var posts = db.Posts.Select(
                p => new
                {
                    ID =p.ID,
                    PostTitle = p.Title,
                    CommentsCount = p.Comments.Count(),
                    TagsCount = p.Tags.Count(),
                    AuthorName = p.User.FullName
                });
            foreach (var p in posts)
            {
                Console.WriteLine(p);
            }

        }

    }
}
