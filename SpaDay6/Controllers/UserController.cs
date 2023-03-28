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

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost("user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.Username = newUser.Username;
                return View("index");
            }
            else
            {
                ViewBag.Username = newUser.Username;
                ViewBag.Email = newUser.Email;
                ViewBag.Password = newUser.Password;
                ViewBag.verify = verify;
                ViewBag.error = "Passwords must match!";
                return View("add");
            }
        }

    }
}
