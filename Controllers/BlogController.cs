using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore_blog.Models.Services;

namespace netcore_blog.Controllers
{
    public class BlogController: Controller
    {
        private readonly IBlogServices _blogServices;
        public BlogController(IBlogServices blogServices)
        {
            _blogServices = blogServices;
        }
        public IActionResult Index()
        {
            var post = _blogServices.GetLatestPosts(10);
            return View("Index", post);
        }

        public IActionResult Archive(int year, int month)
        {
            var posts = _blogServices.GetPostsByDate(year, month);
            return View(posts);
        }
    }
}
