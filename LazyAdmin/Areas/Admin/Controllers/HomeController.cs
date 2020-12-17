using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazyAdmin.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        /// <summary>
        /// 管理后台首页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// 首页控制台
        /// </summary>
        /// <returns></returns>
        public IActionResult Console()
        {
            return View();
        }
    }
}
