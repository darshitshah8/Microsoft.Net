using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniProjectMVC.Models;

namespace MiniProjectMVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;
        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }
        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddressController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            if(ModelState.IsValid == false)
            {
                _logger.LogWarning("The user submitted invalid address upon created");
                return View();
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
