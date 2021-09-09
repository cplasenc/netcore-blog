using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcore_blog.Controllers
{
    public class BlogController: Controller
    {
        private readonly IBlogServices blogServices;
        public BlogController(IBlogServices blogServices)
        {
            _blogServices = blogServices;
        }
        public IActionResult Index()
        {
            var post = _blogServices.GetLatestPost(10);
            return View("Index", post);
        }
    }
}
