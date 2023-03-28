using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

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

        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.Username = newUser.Username;
                return View();
            }
            else
            {
                return View("add");
            }
        }

    }
}
