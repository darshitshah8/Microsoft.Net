using CascadingUsingJQuery.Data;
using CascadingUsingJQuery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace CascadingUsingJQuery.Controllers
{
    public class HomeController : Controller
    {
        private Login _config;
        public HomeController(IConfiguration config)
        {
            _config = new Login(config);
        }
        public IActionResult Index() => View();
        public IActionResult SignIn() => View();
        public IActionResult SignUp() => View();
        public IActionResult GetById() => View();
        
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("SignIn");
        }
        public IActionResult Home()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View("SignIn");
            }
            return View();
        }
        public IActionResult Help()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View("SignIn");
            }
            return View();
        }
        public JsonResult ViewAccount(UserModel acc) 
            => Json(_config.SignInAccount(acc, HttpContext));

        public JsonResult AddAccount(UserModel acc)
            => Json(_config.SignUpAccount(acc));
        
       
       
    }
}
