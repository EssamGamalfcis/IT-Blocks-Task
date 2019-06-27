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
    public class LoanController : Controller
    {
        
        private readonly ILoanService context;

        public LoanController(ILoanService _context)
        {
            context = _context;
        }

        // GET: Loan
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
                    var bookloans = context.GetAll();
                    return View(bookloans);
                }
            }
            catch
            {
                return RedirectToAction("Login", "Home");
            }
        }

        

        // GET: Loan/Create
        public IActionResult Create()
        {
            var books = context.GetAllBooks();
            var loans = context.GetAllLoans();
            ViewData["BookId"] = new SelectList(books, "BookId", "BookName");
            ViewData["LoanId"] = new SelectList(loans, "LoanId", "LoanPFname");
            return View();
        }

        // POST: Loan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,LoanId,DeleteFlag,LoanDate,LoanReturnDate")] BookLoan bookLoan)
        {
            int CountOfBooks = context.GetBookById(bookLoan.BookId).BookAmount;
            if (CountOfBooks > 0)
            {
                bookLoan.LoanDate = DateTime.Now;
                if (ModelState.IsValid)
                {
                    context.Create(bookLoan);
                    return RedirectToAction(nameof(Index));
                }
                var books = context.GetAllBooks();
                var loans = context.GetAllLoans();
                ViewData["BookId"] = new SelectList(books, "BookId", "BookName", bookLoan.BookId);
                ViewData["LoanId"] = new SelectList(loans, "LoanId", "LoanPFname", bookLoan.LoanId);
                return View(bookLoan);
            }
            else
            {
                TempData["AmountError"] = "The Amount of this book doesn't allow this operation";
                var books = context.GetAllBooks();
                var loans = context.GetAllLoans();
                ViewData["BookId"] = new SelectList(books, "BookId", "BookName", bookLoan.BookId);
                ViewData["LoanId"] = new SelectList(loans, "LoanId", "LoanPFname", bookLoan.LoanId);
                return View(bookLoan);
            }
            
        }

        // GET: Loan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var bookLoan = context.GetBookLoanById(id.GetValueOrDefault());
            if (bookLoan == null)
            {
                return NotFound();
            }
            var books = context.GetAllBooks();
            var loans = context.GetAllLoans();
            ViewData["BookId"] = new SelectList(books, "BookId", "BookName", bookLoan.BookId);
            ViewData["LoanId"] = new SelectList(loans, "LoanId", "LoanPFname", bookLoan.LoanId);
            ViewData["LoanReturnDate"] = bookLoan.LoanReturnDate;

            return View(bookLoan);
        }

        // POST: Loan/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int BlId, [Bind("BlId,BookId,LoanId,DeleteFlag,LoanDate,LoanReturnDate")] BookLoan bookLoan)
        {
            if (BlId != bookLoan.BlId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bookLoan.LoanDate = DateTime.Now;
                    context.Edit(bookLoan);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookLoanExists(BlId))
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
            var books = context.GetAllBooks();
            var loans = context.GetAllLoans();
            ViewData["BookId"] = new SelectList(books, "BookId", "BookName", bookLoan.BookId);
            ViewData["LoanId"] = new SelectList(loans, "LoanId", "LoanPFname", bookLoan.LoanId);
            return View(bookLoan);
        }

        // GET: Loan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookLoan = context.GetBookLoanById(id.GetValueOrDefault());
            if (bookLoan == null)
            {
                return NotFound();
            }

            return View(bookLoan);
        }

        // POST: Loan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var bookLoan = context.GetBookLoanById(id.GetValueOrDefault());
            context.Delete(bookLoan);
            return RedirectToAction(nameof(Index));
        }

        private bool BookLoanExists(int id)
        {
            var BookLoan= context.GetBookLoanById(id);
            if (BookLoan != null)
                return true;
            else
                return false;
        }
    }
}
