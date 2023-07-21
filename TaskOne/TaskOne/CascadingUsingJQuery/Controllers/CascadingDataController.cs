using CascadingUsingJQuery.Data;
using CascadingUsingJQuery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using TaskWeb.Controllers;
using TaskWeb.Models;

namespace CascadingUsingJQuery.Controllers
{
    public class CascadingDataController : Controller
    {

        private AllData _data;
        public CascadingDataController(IConfiguration config)
        {
            _data = new AllData(config);
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Get()
        {
            //if (HttpContext.Session.GetString("UserName") == null)
            //{
            //    return RedirectToAction("SignIn", "Home");
            //}
                return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public JsonResult List()
        => Json(_data.ListAll());
       
        public ActionResult GetAllbyId(int id) 
        => Json(_data.ListById(id).Where(x => x.CountryId == id));
    }

}


















// WorldDbContext db = new WorldDbContext();
// var data = db.AllCascadingDatas.FromSql($"Select c.*,s.StateName,ci.CityName from dbo.Country as c left join dbo.State as s on c.CountryId = s.CountryId left join dbo.City as ci on s.StateId = ci.StateId WHERE c.CountryId = {id}").ToList();