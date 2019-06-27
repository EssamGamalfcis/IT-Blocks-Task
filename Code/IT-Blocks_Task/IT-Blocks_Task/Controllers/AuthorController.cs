using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Services;
using Microsoft.AspNetCore.Http;

namespace IT_Blocks_Task.Controllers
{
    public class AuthorController : Controller
    {
        //private readonly ITBlocks_TaskContext _context;
        private readonly IAuthorService context;

        public AuthorController(IAuthorService _context)
        {
            context = _context;
        }

        public IActionResult logout()
        {
            /*session destroy*/
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("RoleId");
            return RedirectToAction("Login", "Home");
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            try
            {
                if (int.Parse(HttpContext.Session.GetString("RoleId")) != 2)/*authentication test*/
                {

                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    var books = context.GetAllBooksByID(int.Parse(HttpContext.Session.GetString("UserId")));
                    return View(books);
                }
            }
            catch
            {
                return RedirectToAction("Login", "Home");
            }
        }

        //GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = context.GetBookByID(id.GetValueOrDefault());
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

          }
}
