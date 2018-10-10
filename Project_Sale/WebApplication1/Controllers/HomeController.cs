using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuctionSite.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISessionWapper _sessionWapper;

        public HomeController(ISessionWapper sessionWapper) {
            _sessionWapper = sessionWapper;
        }
        public IActionResult TaobaoDataBase()
        {
            ViewData["Title"] = "淘寶資料表";
            ViewData["ShowNav"] = "True";
            return View();
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "倉儲管理";
            ViewData["ShowNav"] = "True";
            return View();
        }
        public IActionResult LocalDataBase()
        {
            ViewData["Title"] = "本地資料表";
            ViewData["ShowNav"] = "True";

            return View();
        }

        public IActionResult Report()
        {
            ViewData["Title"] = "報表";
            ViewData["ShowNav"] = "True";
            var user = _sessionWapper.User;
            _sessionWapper.User = user;
            //return Ok(user);
            return View();
        }
        public IActionResult Login()
        {
            ViewData["Title"] = "會員登入";
            ViewData["ShowNav"] = "False";
            UserModel user = new UserModel();

            return View();
        }
      
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
