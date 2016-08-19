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
            foreach (var p in db.Posts)
            {
                Console.WriteLine(p.ID + " " + p.Title);
                foreach (var c in p.Comments)
                {
                    Console.WriteLine($"\t {c.ID} {c.Text}");
                }
            }
        }

    }
}
