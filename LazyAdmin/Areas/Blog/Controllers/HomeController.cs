using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazyAdmin.Blog.Controllers
{
    [Area("Blog")]
    public class HomeController : Controller
    {
        /// <summary>
        /// 博客首页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
