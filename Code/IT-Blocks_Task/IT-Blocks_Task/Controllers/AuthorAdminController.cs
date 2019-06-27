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
    public class AuthorAdminController : Controller
    {

        private readonly IAuthorAdminService context;

        public AuthorAdminController(IAuthorAdminService _context)
        {
            context = _context;
        }

        // GET: AuthorAdmin
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
                    var users = context.GetAll();
                    return View(users);
                }
            }
            catch
            {
                return RedirectToAction("Login", "Home");
            }
        }

        // GET: AuthorAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = context.GetAuthorById(id.GetValueOrDefault());
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: AuthorAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AuthorAdmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserFname,UserLname,UserLoginId,UserLoginPasswrod,RoleId,DeleteFlag")] User user)
        {
            user.RoleId = 2;
            if (ModelState.IsValid)
            {
                context.Create(user);
                return RedirectToAction(nameof(Index));
            }
           // TempData["RoleId"] = 2;
            
            return View(user);
        }

        // GET: AuthorAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = context.GetAuthorById(id.GetValueOrDefault());
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = 2;
            return View(user);
        }

        // POST: AuthorAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int UserId, [Bind("UserId,UserFname,UserLname,UserLoginId,UserLoginPasswrod,RoleId,DeleteFlag")] User user)
        {
            user.RoleId = 2;
            if (UserId != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Edit(user);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
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
            ViewData["RoleId"] = 2;
            return View(user);
        }

        // GET: AuthorAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int NumOfBooks = context.GetAllBooksByAuthordId(id.GetValueOrDefault());
            var user = context.GetAuthorById(id.GetValueOrDefault());
            if (NumOfBooks > 0)
            {
                TempData["CustomError"] = "This Author Still Have Books In Library Please Delete Them First";
                return RedirectToAction("Index");
            }
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: AuthorAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int UserId)
        {
           
                context.Delete(UserId);
                return RedirectToAction(nameof(Index));
            
        }

        private bool UserExists(int id)
        {

            var user = context.GetAuthorById(id);
            if (user == null)
            {
                return false;
            }
            else
                return true;
        }
    }
}
