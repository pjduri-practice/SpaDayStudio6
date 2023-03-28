﻿using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.user = newUser;
            if (newUser.Password == verify)
            {
                
                ViewBag.username = newUser.Username;
                return View("index");
            }
            else
            {
                ViewBag.error = "Passwords do not match! Try again!";
                return View("add");
            }
        }

    }
}
