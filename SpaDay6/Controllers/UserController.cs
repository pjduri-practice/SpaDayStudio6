﻿using Microsoft.AspNetCore.Mvc;

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {


            return View();
        }
    }
}
