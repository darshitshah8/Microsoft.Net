using HomeworkASP.NETMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkASP.NETMVC.Controllers
{
    public class SayMyName : Controller
    {

        // GET: SayMyName/Create
        public ActionResult Create(PersonModel person)
        {
            ViewBag.FirstName = person.FirstName;
            ViewBag.LastName = person.LastName;
            return View(nameof(Create));
        }

    }
}
