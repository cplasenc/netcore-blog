using netcore_blog.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_blog.Models.Services
{
    public interface IBlogServices
    {
        IEnumerable<Post> GetLatestPosts(int max);
        IEnumerable<Post> GetPostsByDate(int year, int month);
    }
}
