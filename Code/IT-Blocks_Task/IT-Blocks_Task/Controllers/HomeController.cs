using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IT_Blocks_Task.Models;
using Domain;
using Microsoft.AspNetCore.Http;
using Services;

namespace IT_Blocks_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService iuserService;



        public HomeController(IUserService _iuserService)
        {
            this.iuserService = _iuserService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username , string password)
        {

            User user = iuserService.Login(username, password);
            if (user != null)
            {
                HttpContext.Session.SetString("UserId", user.UserId.ToString());
                HttpContext.Session.SetString("RoleId", user.RoleId.ToString());

            }
            if (user == null)
            {
                ModelState.AddModelError("CustomError", "Login faild");
                return View();
            }
            else if (user.RoleId == 1) //Admin
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (user.RoleId == 2) //Author
            {
                return RedirectToAction("Index", "Author");
            }
          


            return View();

        }


        public IActionResult Index()
        {
            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
