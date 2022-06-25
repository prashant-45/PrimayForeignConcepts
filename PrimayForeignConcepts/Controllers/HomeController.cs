using Microsoft.AspNetCore.Mvc;
using PrimayForeignConcepts.Models;
using System.Diagnostics;

namespace PrimayForeignConcepts.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            //DbContext db = new DbContext();
           // var row = db.AddEmployee();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            try
            {
                DbContext dbContext = new DbContext();
                bool i = dbContext.AddEmployee(emp);
                if (i == true)
                {
                    TempData["msg"] = "success";
                }
                else
                {
                    TempData["msg"] = "error";
                }
            }
            catch (Exception e)
            {
                TempData["msg"] = "error : "+e;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}