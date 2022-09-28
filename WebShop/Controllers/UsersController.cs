
using Microsoft.AspNetCore.Mvc;
using WebShop.Repository;
using WebShop.Services;

namespace WebShop.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Username))
            {
                isValid = false;
                ViewData["usernameError"] = "This field is Required!";
            }

            if (string.IsNullOrEmpty(Password))
            {
                isValid = false;
                ViewData["passwordError"] = "This field is Required!";
            }

            if (isValid)
                AuthenticationService.AuthenticateUser(Username, Password);
            if (AuthenticationService.LoggedUser != null)
            {
                if (AuthenticationService.LoggedUser.isAdmin)
                {
                    return RedirectToAction("Index", "AdminView");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }


            ViewData["username"] = Username;
            ViewData["password"] = Password;

            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string Name, string Username, string Password)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Username))
            {
                isValid = false;
                ViewData["usernameError"] = "This field is Required!";
            }

            if (string.IsNullOrEmpty(Password))
            {
                isValid = false;
                ViewData["passwordError"] = "This field is Required!";
            }

            if (string.IsNullOrEmpty(Name))
            {
                isValid = false;
                ViewData["nameError"] = "This field is Required!";
            }


            if (isValid)
            {
                UserRepository userRepository = new UserRepository();
                userRepository.Register(Name, Username, Password, true);
                return RedirectToAction("Index", "Home");
            }

            ViewData["username"] = Username;
            ViewData["password"] = Password;
            ViewData["name"] = Name;

            return View();
        }
    }
}
