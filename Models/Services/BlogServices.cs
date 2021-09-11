using netcore_blog.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_blog.Models.Services
{
    public class BlogServices : IBlogServices
    {
        private static readonly List<Post> Posts;
        static BlogServices()
        {
            Posts = new List<Post>
            {
                new Post() {Title = "Bienvenido a MVC", Slug = "bienvenido-a-mvc",
                Author = "jmaguilar",
                Text = "Hi Bienvenido a MVC",
                Date = new DateTime(2021, 07, 07)},
                new Post() {Title = "Bienvenido a MVC2", Slug = "bienvenido-a-mvc",
                Author = "jmaguilar",
                Text = "Hi Bienvenido a MVC2",
                Date = new DateTime(2021, 07, 07)},
                new Post() {Title = "Bienvenido a MVC3", Slug = "bienvenido-a-mvc",
                Author = "jmaguilar",
                Text = "Hi Bienvenido a MVC3",
                Date = new DateTime(2021, 07, 07)},
                new Post() {Title = "Bienvenido a MVC4", Slug = "bienvenido-a-mvc",
                Author = "jmaguilar",
                Text = "Hi Bienvenido a MVC4",
                Date = new DateTime(2021, 07, 07)},
            };
            for (int i = 1; i < 5; i++)
            {
                Posts.Add(new Post()
                {
                    Title = $"Post number {i}",
                    Slug = $"psot-number {i}",
                    Author = $"jmaguilar",
                    Text = $"Text of post #{i}",
                    Date = new DateTime(216, 06, 01).AddDays(i)
                });
            }
        }

        public IEnumerable<Post> GetLatestPosts(int max)
        {
             
        }
    }
}
