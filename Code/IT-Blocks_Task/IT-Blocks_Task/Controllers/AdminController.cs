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
    public class AdminController : Controller
    {

        private readonly IBookService context;

        public AdminController(IBookService _context)
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
        /// <summary>
        /// Search
        /// </summary>
        /// <param name="SearchWord"></param>
        /// <returns></returns>
        public async Task<IActionResult> Search(string BookName)
        {

            var book = context.Search(BookName);

            if (book == null)
            {
                Book bookSearch = new Book();
                TempData["NotFound"] = "Not Found";
                return View(bookSearch);
            }
            
            return View(book);
        }


        // GET: Admin
        public async Task<IActionResult> Index()
        {

            try
            {
                if (int.Parse(HttpContext.Session.GetString("RoleId")) != 1)/*authentication test*/
                {

                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    var Books = context.GetAll();
                    return View(Books);
                }
            }
            catch
            {
                return RedirectToAction("Login", "Home");
            }




           
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = context.GetBookById(id.GetValueOrDefault());
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(context.GetAllAuthor(), "UserId", "UserLoginId");
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,BookName,BookDescription,BookAmount,AuthorId,DeleteFlag")] Book book)
        {
            if (ModelState.IsValid)
            {
                context.Create(book);
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AuthorId"] = new SelectList(_context.User, "UserId", "UserLoginId", book.AuthorId);
            return View(book);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = context.GetBookById(id.GetValueOrDefault());
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(context.GetAllAuthor(), "UserId", "UserLoginId", book.AuthorId);
            return View(book);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,BookName,BookDescription,BookAmount,AuthorId,DeleteFlag")] Book book)
        {
            

            if (ModelState.IsValid)
            {
                try
                {
                    context.Edit(book);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AuthorId"] = new SelectList(_context.User, "UserId", "UserLoginId", book.AuthorId);
            return View(book);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = context.GetBookById(id.GetValueOrDefault());
            int LoanCount = context.LoanCount(id.GetValueOrDefault());
            if (book == null)
            {
                return NotFound();
            }

            if (LoanCount > 0)
            {
                TempData["CustomError"] = "This Book Still Borrowed Please Delete Loans Connected to This Book First";
                return RedirectToAction("Index");
            }

            return View(book);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int BookId)
        {
           context.Delete(BookId);
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            var book = context.GetBookById(id);
            if (book == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
