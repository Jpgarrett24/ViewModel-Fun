using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;


namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            string Message = "Now, this is a story all about how my life got flipped-turned upside down and I'd like to take a minute, just sit right there... I'll tell you how I became the prince of a town called Bel Air.";
            return View("Index", Message);
        }

        [HttpGet("numbers")]
        public ViewResult Numbers()
        {
            int[] Nums = { 8, 13, 22, 24, 25, 32, 33, 34, 42, 44, 52 };
            return View("Numbers", Nums);
        }

        [HttpGet("user")]
        public ViewResult ShowUser()
        {
            User LBJ = new User("LeBron", "James");
            return View("User", LBJ);
        }

        [HttpGet("users")]
        public ViewResult ShowUsers()
        {
            List<User> Users = new List<User>();
            Users.Add(new Models.User("LeBron", "James"));
            Users.Add(new Models.User("Kobe", "Bryant"));
            Users.Add(new Models.User("Kareem", "Abdul-Jabbar"));
            Users.Add(new Models.User("Wilt", "Chamberlain"));
            return View("Users", Users);
        }
    }
}
