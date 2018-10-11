using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuctionSite.Models;

namespace AuctionSite.Controllers
{
    public class ButtonClickController:Controller
    {
        public IActionResult Signin(UserModel user)//string Email,string Password
        {
            ViewData["Title"] = "倉儲管理";
            ViewData["ShowNav"] = "True";
            return View("Views/Home/Index.cshtml");
        }


    }
}
