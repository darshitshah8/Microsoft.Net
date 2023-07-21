using Microsoft.AspNetCore.Mvc;
using SessionManagementDemo.Models;

namespace SessionManagementDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                return RedirectToAction("Dashboard");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(SessionModel model)
        {
            if (IsValidUser(model.UserName, model.User_Pwd))
            {
                HttpContext.Session.SetString("Username", model.UserName);
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid username or password";
            return View();
        }


        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                return View("Dashboard");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Help()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                return View("Help");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        private bool IsValidUser(string username, string password)
        {
            // Implement your authentication logic here
            // For demonstration purposes, let's assume a valid username/password combination
            return username == "Darshit" && password == "12345";
        }
    }

}
